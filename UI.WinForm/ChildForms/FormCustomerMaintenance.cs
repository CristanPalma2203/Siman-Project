using Domain.Models;
using Domain.Models.Contracts;
using Infra.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.WinForm.Helpers;
using UI.WinForm.Utils;
using UI.WinForm.ViewModels;

namespace UI.WinForm.ChildForms
{
    public partial class FormCustomerMaintenance : Base.BaseFixedForm
    {

        #region -> Definición de Campos
        public CustomerViewModel Customer;
        private ICustomerModel domainModel;
        private BindingList<CustomerViewModel> customerCollection;
        private CustomerViewModel customerViewModel;
        private TransactionAction transaction;
        private TransactionAction listOperation = TransactionAction.Add;
        private string lastRecord = "";
        #endregion

        #region -> Definición de Propiedades

        public string LastRecord
        {/*Propiedad para almacenar el ultimo dato insertado o editado.
          Esto permitirá seleccionar y visualizar los cambios en el datagridview del formulario Users.*/
            get { return lastRecord; }
            set { lastRecord = value; }
        }
        #endregion


        #region -> Constructor
        public FormCustomerMaintenance(CustomerViewModel _customerViewModel, TransactionAction _transaction)
        {
            InitializeComponent();
            domainModel = new CustomerModel();
            customerCollection = new BindingList<CustomerViewModel>();
            customerViewModel = _customerViewModel;
            transaction = _transaction;

            rbSingleInsert.Checked = true;
            dataGridView1 = new DataGridView();
            InitializeTransactionUI();
            FillFields(_customerViewModel);
            dataGridView1.DataSource = customerCollection;
            InitializeDataGridView();
        }


        #endregion


        #region -> Definición de métodos

        private void InitializeTransactionUI() {
            switch (transaction) {
                case TransactionAction.View:
                    LastRecord = null;
                    this.TitleBarColor = Color.MediumSlateBlue;
                    lblTitle.Text = "Detalles de Cliente";
                    lblTitle.ForeColor = Color.MediumSlateBlue;
                    btnSave.Visible = false;
                    panelAddedControl.Visible = false;
                    ReadOnlyFields();
                    Disguise();
                    break;
                case TransactionAction.Add:
                    this.TitleBarColor = Color.SeaGreen;
                    lblTitle.Text = "Agregar Clientes";
                    lblTitle.ForeColor = Color.SeaGreen;
                    btnSave.BackColor = Color.SeaGreen;
                    Disguise();
                    break;
                case TransactionAction.Edit:
                    this.TitleBarColor = Color.RoyalBlue;
                    lblTitle.Text = "Editar Cliente";
                    lblTitle.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    panelAddedControl.Visible = false;
                    Disguise();
                    break;
                case TransactionAction.Remove:
                    this.TitleBarColor = Color.IndianRed;
                    lblTitle.Text = "Eliminar Cliente";
                    lblTitle.ForeColor = Color.IndianRed;
                    btnSave.Text = "Eliminar";
                    btnSave.BackColor = Color.IndianRed;
                    panelAddedControl.Visible = false;
                    Disguise();
                    ReadOnlyFields();
                    break;

            }

        }




        private void InitializeDataGridView()
        {//Este método es responsable de agregar columnas de editar y eliminar usuarios
         //de la colección de usuarios de la opción inserción masiva.

            DataGridViewImageColumn EditColumn = new DataGridViewImageColumn();
            DataGridViewImageColumn DeleteColumn = new DataGridViewImageColumn();

            EditColumn.Image = Properties.Resources.editIcon;
            EditColumn.Name = "EditColumn";
            EditColumn.HeaderText = " ";
            DeleteColumn.Image = Properties.Resources.deleteIcon;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.HeaderText = " ";

            this.dataGridView1.Columns.Add(EditColumn);
            this.dataGridView1.Columns.Add(DeleteColumn);

            dataGridView1.Columns["EditColumn"].Width = 25;
            dataGridView1.Columns["DeleteColumn"].Width = 25;
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 100;
        }

        private void PersistSigleRow()
        {
            try {
                var customerObject = FillViewModel();
                var validateData = new DataValidation(customerObject);//Validar campos del objeto.

                var catalogueModel = customerViewModel.MapCustomerModel(customerObject);//Mapear el modelo de vista a modelo de dominio.
                switch (transaction)
                {
                    case TransactionAction.Add://Agregar usuario.
                        AddCustomer(catalogueModel);
                        break;
                    case TransactionAction.Edit://Editar usuario.
                        EditCustomer(catalogueModel);
                        break;
                    case TransactionAction.Remove://Eliminar usuario.
                        RemoveCustomer(catalogueModel);
                        break;
                    case TransactionAction.Special://Actualizar perfil de usuario
                        break;
                }
            }
            catch (Exception ex)
            {
                LastRecord = null;//Establecer nulo como ultimo registro.
                var message = ExceptionManager.GetMessage(ex);//Obtener mensaje de excepción.
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostrar mensaje.
            }

        }
        private void PersistMultipleRows()
        {//Método para persistir varias filas en la base de datos (Inserción masiva).
            try
            {
                if (customerCollection.Count > 0)//Validar si hay datos a insertar.
                {
                    var customerModelList = customerViewModel.MapCustomerModel(customerCollection.ToList());//Mapear la colección de usuarios a colección de modelos de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add:
                            AddCustomerRange(customerModelList);//Agregar rango de usuarios.
                            break;
                    }
                }
                else MessageBox.Show("No hay datos, por favor agregue datos en la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                LastRecord = null;
                var message = ExceptionManager.GetMessage(ex);
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddCustomer(CustomerModel catalogueModel)
        {
            var result = domainModel.Add(catalogueModel);
            if (result > 0)
            {
                LastRecord = catalogueModel.NameCustemer;//Establecer el ultimo registro.
                MessageBox.Show("Cliente agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddCustomerRange(List<CustomerModel> custoemrModelList)
        {
            var result = domainModel.AddRange(custoemrModelList);

            if (result > 0)
            {
                LastRecord = custoemrModelList[0].NameCustemer;//Establecer el primer objeto como ultimo registro.
                MessageBox.Show("se agregaron " + result.ToString() + " Cliente con éxito");
                this.Close();
            }
            else
            {
                lastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void EditCustomer(CustomerModel customerModel)
        {
            var result = domainModel.Edit(customerModel);
            if (result > 0)
            {
                LastRecord = customerModel.NameCustemer;//Establecer el ultimo registro.
                MessageBox.Show("Cliente actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void RemoveCustomer(CustomerModel customerModel)
        {
            var result = domainModel.Remove(customerModel);
            if (result > 0)
            {
                LastRecord = "";//Establecer una cadena vacía como ultimo registro, ya que el usuario ya no existe, por lo tanto no es posible seleccionar y visualizar los cambios (Ver formulario Users).
                MessageBox.Show("Cliente eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifyCstomerCollection()
        {//Este método es responsable de agregar o modificar un usuario de la colección de usuarios para la insercion masiva.
            var customerObject = FillViewModel();

            var validateData = new DataValidation(customerObject);//Validar objeto.

            switch (listOperation)
            {
                case TransactionAction.Add:
                    var findCatalogue = customerCollection.FirstOrDefault(customer => customer.NameCustemer == customerObject.Email
                                                               || customer.NameCustemer == customerObject.Email);
                    if (findCatalogue == null)
                    {
                        var lastCatalogue = customerCollection.LastOrDefault();
                        if (lastCatalogue == null) customerObject.IdCustemer = 1;
                        else customerObject.IdCustemer = lastCatalogue.IdCustemer + 1;

                        customerCollection.Add(customerObject);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Dato duplicado.\nEmail o nombre de Clientes ya se ha añadido",
                            "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case TransactionAction.Edit:
                    var findObject = customerCollection.SingleOrDefault(customer => customer.IdCustemer == customerViewModel.IdCustemer);
                    var index = customerCollection.IndexOf(findObject);
                    customerCollection[index] = customerObject;

                    customerCollection.ResetBindings();
                    ClearFields();
                    break;
            }

           
        }
        private void FillFields(CustomerViewModel customerView)
        {//Cargar los datos del modelo de vista en los campos del formulario.
            txtName.Text = customerView.NameCustemer;
            txttArchivioID.Text = customerView.ArchiIdC.ToString();
            txtLastName.Text = customerView.LastName;
            txtAddress.Text = customerView.Address;
            txtfEmail.Text = customerView.Email;
            txtphoneNumber.Text = customerView.Phone;
        }

        private CustomerViewModel FillViewModel()
        {//LLenar y retornar los datos de los campos del formulario en un nuevo objeto.
            var customerView = new CustomerViewModel();

            customerView.IdCustemer = customerViewModel.IdCustemer;
            customerView.NameCustemer = txtName.Text;
            customerView.ArchiIdC = Convert.ToInt32(txttArchivioID.Text);
            customerView.Email = txtfEmail.Text;
            customerView.Address =txtAddress.Text;
            customerView.Phone = txtphoneNumber.Text;
            customerView.LastName= txtLastName.Text;
            return customerView;
        }


        private void ClearFields()
        {//Limpiar los campos del formulario.
            txtName.Clear();
            txttArchivioID.Clear();
            txtfEmail.Clear();
            txtAddress.Clear();
            txtLastName.Clear();
            txtphoneNumber.Clear();

            listOperation = TransactionAction.Add;
            btnAddUser.Text = "Agregar";
            btnAddUser.BackColor = Color.CornflowerBlue;
        }
        private void ReadOnlyFields()
        {//Convertir los campos del formulario en solo lectura.
            txtName.ReadOnly = true;
            txttArchivioID.ReadOnly = true;
            txtfEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtphoneNumber.ReadOnly = true;
            btnAddPhoto.Enabled = false;
            btnDeletePhoto.Enabled = false;
        }

        private void Disguise() { 
            btnDeletePhoto.Visible = false;
            btnAddPhoto.Visible = false;
            label3.Visible = false;

        }

        private void PersistSingleRow()
        {//Método para persistir una sola fila en la base de datos.
            try
            {
                var customerObject = FillViewModel();//Obtener modelo de vista

                var productModel = customerViewModel.MapCustomerModel(customerObject);//Mapear el modelo de vista a modelo de dominio.
                switch (transaction)
                {
                    case TransactionAction.Add://Agregar producto.
                        AddCustomer(productModel);
                        break;
                    case TransactionAction.Edit://Editar producto.
                        EditCustomer(productModel);
                        break;
                    case TransactionAction.Remove://Eliminar producto.
                        RemoveCustomer(productModel);
                        break;
                    case TransactionAction.Special://Actualizar perfil de product
                        break;
                }


            }
            catch (Exception ex)
            {
                LastRecord = null;//Establecer nulo como ultimo registro.
                var message = ExceptionManager.GetMessage(ex);//Obtener mensaje de excepción.
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostrar mensaje.
            }

        }

        private void rbSingleInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSingleInsert.Checked)//Cambiar la apariencia para la inserción única.
            {
                panelMultiInsert.Visible = false;
                btnCancel.Location = new Point(210, 310);
                btnSave.Location = new Point(386, 310);
                this.Size = new Size(754, 370);
            }
            else //Cambiar la apariencia para insercción masiva.
            {
                panelMultiInsert.Visible = true;
                btnCancel.Location = new Point(212, 654);
                btnSave.Location = new Point(388, 654);
                this.Size = new Size(754, 715);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbSingleInsert.Checked) //Si el botón de radio está activado.
                PersistSingleRow();//Ejecutar el método de persistir una sola fila.
            else //Caso contrario, ejecutar el método de persistir varias filas(Insercción masiva)
                PersistMultipleRows();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LastRecord = null;
            this.Close();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {//Cambiar el cursor si puntero del mouse entra en la columna de editar o eliminar.
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index
                || e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index)
            {
                dataGridView1.Cursor = Cursors.Hand;
            }
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {//Cambiar el cursor si puntero del mouse entra en la columna de editar o eliminar.
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index
                || e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index)
            {
                dataGridView1.Cursor = Cursors.Default;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Eliminar o editar un usuario de la colección de usuarios.
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index)
            {
                if (listOperation != TransactionAction.Edit)
                    customerCollection.RemoveAt(e.RowIndex);
                else MessageBox.Show("Se está editando datos, por favor termine la operación.");
            }
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index)
            {
                customerViewModel = customerCollection[e.RowIndex];
                FillFields(customerViewModel);
                listOperation = TransactionAction.Edit;
                btnAddUser.Text = "Actualizar";
                btnAddUser.BackColor = Color.MediumSlateBlue;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ModifyCstomerCollection();
        }

        #endregion

    }
}
