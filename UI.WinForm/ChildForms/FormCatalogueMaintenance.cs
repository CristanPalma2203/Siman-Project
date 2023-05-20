using Domain.Models;
using Domain.Models.Contracts;
using Infra.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UI.WinForm.Helpers;
using UI.WinForm.Utils;
using UI.WinForm.ViewModels;

namespace UI.WinForm.ChildForms
{
    public partial class FormCatalogueMaintenance : Base.BaseFixedForm
    {
        #region -> Definición de Campos
        public UserViewModel User;
        private UserViewModel userViewModel;
        private ICatalogueModel domainModel;//Interfaz del modelo de dominio Usuario.
        private BindingList<CatalogueViewModel> catalogueCollection;//Colección de usuarios para la inserción masiva.
        private CatalogueViewModel catalogueViewModel;//Modelo de vista del usuario.
        private TransactionAction transaction;//Acción de transacción para la persistencia.
        private TransactionAction listOperation = TransactionAction.Add; //Acción de transacción para la colección de usuarios.
        private string lastRecord = "";/*Campo para almacenar el ultimo dato insertado o editado.
                                         Esto permitirá seleccionar y visualizar los cambios en el datagridview del formulario Users.*/
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

        public FormCatalogueMaintenance(CatalogueViewModel _catalogueViewModel, TransactionAction _transaction)
        {
            InitializeComponent();

            //Inicializar campos
            domainModel = new CatalogueModel();
            catalogueCollection = new BindingList<CatalogueViewModel>();
            catalogueViewModel = _catalogueViewModel;
            transaction = _transaction;
      

            //Inicializar propiedades de control
            rbSingleInsert.Checked = true;
            dataGridView1.DataSource = catalogueCollection;
            FillFields(_catalogueViewModel);
            InitializeTransactionUI();
            InitializeDataGridView();
        }
        #endregion

        #region -> Definición de métodos

        private void InitializeTransactionUI()
        {//Este método es responsable de establecer las propiedades de apariencia según la acción de la transacción.
            switch (transaction)
            {
                case TransactionAction.View:
                    LastRecord = null;
                    this.TitleBarColor = Color.MediumSlateBlue;
                    lblTitle.Text = "Detalles de Catalogo";
                    lblTitle.ForeColor = Color.MediumSlateBlue;
                    btnSave.Visible = false;
                    panelAddedControl.Visible = false;
                    btnCancel.Text = "X  Cerrar";
                    btnCancel.Location = new Point(300, 310);
                    btnCancel.BackColor = Color.MediumSlateBlue;
                    ReadOnlyFields();
                    break;

                case TransactionAction.Add:
                    var u = new UserViewModel();
                    

                 //   catalogueView.CatelogueId = catalogueViewModel.CatelogueId;
                    this.TitleBarColor = Color.SeaGreen;
                    lblTitle.Text = "Agregar Catalogo";
                    lblTitle.ForeColor = Color.SeaGreen;
                    btnSave.BackColor = Color.SeaGreen;
                   txtusuarioCrea.Text = u.Id.ToString();
               txtUsuarioUpdate.Text = "2";
                    txtfechacreacion.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtFechaUpde.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    FunctionsAdd();
                    break;

                case TransactionAction.Edit:
                    this.TitleBarColor = Color.RoyalBlue;
                    lblTitle.Text = "Editar Catalogo";
                    lblTitle.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    panelAddedControl.Visible = false;
                    txtusuarioCrea.Text = "1";
                    txtUsuarioUpdate.Text = "2";
                    txtFechaUpde.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    FuntionsEdit();
                    break;

                case TransactionAction.Remove:
                    this.TitleBarColor = Color.IndianRed;
                    lblTitle.Text = "Eliminar Catalogo";
                    lblTitle.ForeColor = Color.IndianRed;
                    btnSave.Text = "Eliminar";
                    btnSave.BackColor = Color.IndianRed;
                    panelAddedControl.Visible = false;
                 
                    ReadOnlyFields();
                    break;

                case TransactionAction.Special:
                    this.TitleBarColor = Color.RoyalBlue;
                    lblTitle.Text = "Actualizar mi perfil de Catalogo";
                    lblTitle.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    panelAddedControl.Visible = false;
                
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

        private void PersistSingleRow()
        {//Método para persistir una sola fila en la base de datos.
            try
            {
                var catalogueObject = FillViewModel();//Obtener modelo de vista.
                var validateData = new DataValidation(catalogueObject);//Validar campos del objeto.
            
                    var catalogueModel = catalogueViewModel.MapCatalogueModel(catalogueObject);//Mapear el modelo de vista a modelo de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add://Agregar usuario.
                        AddCatalogue(catalogueModel);
                            break;
                        case TransactionAction.Edit://Editar usuario.
                            EditCatalogue(catalogueModel);
                            break;
                        case TransactionAction.Remove://Eliminar usuario.
                            RemoveCatalogue(catalogueModel);
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
                if (catalogueCollection.Count > 0)//Validar si hay datos a insertar.
                {
                    var userModelList = catalogueViewModel.MapCatalogueModel(catalogueCollection.ToList());//Mapear la colección de usuarios a colección de modelos de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add:
                            AddCatalogueRange(userModelList);//Agregar rango de usuarios.
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
        private void AddCatalogue(CatalogueModel catalogueModel)
        {
            var result = domainModel.Add(catalogueModel);
            if (result > 0)
            {
                LastRecord = catalogueModel.NameCa;//Establecer el ultimo registro.
                MessageBox.Show("Catalogo agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void AddCatalogueRange(List<CatalogueModel> catalogueModelList)
        {
            var result = domainModel.AddRange(catalogueModelList);

            if (result > 0)
            {
                LastRecord = catalogueModelList[0].NameCa;//Establecer el primer objeto como ultimo registro.
                MessageBox.Show("se agregaron " + result.ToString() + " Catalogo con éxito");
                this.Close();
            }
            else
            {
                lastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void EditCatalogue(CatalogueModel catalogueModel)
        {
            var result = domainModel.Edit(catalogueModel);
            if (result > 0)
            {
                LastRecord = catalogueModel.NameCa;//Establecer el ultimo registro.
                MessageBox.Show("Catalogo actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void RemoveCatalogue(CatalogueModel catalogueModel)
        {
            var result = domainModel.Remove(catalogueModel);
            if (result > 0)
            {
                LastRecord = "";//Establecer una cadena vacía como ultimo registro, ya que el usuario ya no existe, por lo tanto no es posible seleccionar y visualizar los cambios (Ver formulario Users).
                MessageBox.Show("Catalogo eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifyCatalogueCollection()
        {//Este método es responsable de agregar o modificar un usuario de la colección de usuarios para la insercion masiva.
            var userObject = FillViewModel();

            var validateData = new DataValidation(userObject);//Validar objeto.
          
                switch (listOperation)
                {
                    case TransactionAction.Add:
                        var findCatalogue = catalogueCollection.FirstOrDefault(user => user.CatelogueName == userObject.TypeCatatalo
                                                                   || user.AbbrevitureCate == userObject.AbbrevitureCate);
                        if (findCatalogue == null)
                        {
                            var lastCatalogue = catalogueCollection.LastOrDefault();
                            if (lastCatalogue == null) userObject.CatelogueId = 1;
                            else userObject.CatelogueId = lastCatalogue.CatelogueId + 1;

                            catalogueCollection.Add(userObject);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Dato duplicado.\nEmail o nombre de usuario ya se ha añadido",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case TransactionAction.Edit:
                        var findObject = catalogueCollection.SingleOrDefault(user => user.CatelogueId == catalogueViewModel.CatelogueId);
                        var index = catalogueCollection.IndexOf(findObject);
                        catalogueCollection[index] = userObject;

                        catalogueCollection.ResetBindings();
                        ClearFields();
                        break;
                }

         
        }

      

        private void FillFields(CatalogueViewModel caalogueView)
        {//Cargar los datos del modelo de vista en los campos del formulario.
            txtName.Text = caalogueView.CatelogueName;
            txttipo.Text = caalogueView.TypeCatatalo;
            txtAbrevitura.Text = caalogueView.AbbrevitureCate;
            txtfather.Text = caalogueView.IdFather.ToString();
            txtfechacreacion.Text = Convert.ToDateTime(caalogueView.CreationTime).ToString("dd/MM/yyyy");
             txtusuarioCrea.Text = caalogueView.CreationUser.ToString();
           // txtusuarioCrea.Text = userViewModel.Id.ToString();
              txtFechaUpde.Text = Convert.ToDateTime(caalogueView.UpdateDate).ToString("dd/MM/yyyy");
           txtUsuarioUpdate.Text = caalogueView.UpdateUser.ToString();
         //   txtUsuarioUpdate.Text = userViewModel.Id.ToString();
        }

        private CatalogueViewModel FillViewModel()
        {//LLenar y retornar los datos de los campos del formulario en un nuevo objeto.
            var catalogueView = new CatalogueViewModel();

            catalogueView.CatelogueId = catalogueViewModel.CatelogueId;
            catalogueView.CatelogueName = txtName.Text;
            catalogueView.TypeCatatalo = txttipo.Text;
            catalogueView.AbbrevitureCate = txtAbrevitura.Text;
            catalogueView.IdFather = Convert.ToInt32(txtfather.Text);
            catalogueView.CreationTime = Convert.ToDateTime(txtfechacreacion.Text);
            catalogueView.CreationUser =Convert.ToInt32(txtusuarioCrea.Text);
            catalogueView.UpdateDate = Convert.ToDateTime(txtFechaUpde.Text);
            catalogueView.UpdateUser = Convert.ToInt32(txtUsuarioUpdate.Text);

            return catalogueView;
        }

        private void ClearFields()
        {//Limpiar los campos del formulario.
            txtName.Clear();
            txttipo.Clear();
            txtAbrevitura.Clear();
            listOperation = TransactionAction.Add;
            btnAddUser.Text = "Agregar";
            btnAddUser.BackColor = Color.CornflowerBlue;
        }
        private void ReadOnlyFields()
        {//Convertir los campos del formulario en solo lectura.
            txtName.ReadOnly = true;
            txttipo.ReadOnly = true;
            txtAbrevitura.ReadOnly = true;
            txtfather.ReadOnly = true;
            txtfechacreacion.ReadOnly = true;
            txtFechaUpde.ReadOnly = true;
            txtusuarioCrea.ReadOnly = true;
            txtUsuarioUpdate.ReadOnly = true;
            btnDeletePhoto.Visible = false;
        }

        private void FuntionsEdit() {
            btnDeletePhoto.Visible=false;
            txtusuarioCrea.Enabled = false;
            txtUsuarioUpdate.Enabled = false;
            txtFechaUpde.Visible = true;
            txtUsuarioUpdate.Visible = true;
            txtUsuarioUpdate.Visible = true;
            txtfechacreacion.Enabled = false;
            txtFechaUpde.Enabled = false;
            label3.Visible = false;
        }

        private void FunctionsAdd() {
            btnDeletePhoto.Visible = false;
            lbl.Visible = false;
            btnAddPhoto.Visible = false;
            btnAddUser.Visible = false;
            label3.Visible = false;
            txtusuarioCrea.Enabled = false;
            lblConfirmPass.Visible = false;
            txtFechaUpde.Visible = false;
            txtUsuarioUpdate.Visible = false;
            txtUsuarioUpdate.Visible = false;
            txtfechacreacion.Enabled = false;
            txtFechaUpde.Enabled = false;
        }

        #endregion

        #region -> Definición de métodos de evento

        private void btnSave_Click(object sender, EventArgs e)
        {//Boton guardar cambio
            if (rbSingleInsert.Checked) //Si el botón de radio está activado.
                PersistSingleRow();//Ejecutar el método de persistir una sola fila.
            else //Caso contrario, ejecutar el método de persistir varias filas(Insercción masiva)
                PersistMultipleRows();
        }

 
        private void btnAddUserList_Click(object sender, EventArgs e)
        {//Botón de agregar usuario a la colección de usuarios para la insercción masiva.
            ModifyCatalogueCollection();
        }
        private void rbSingleInsert_CheckedChanged_1(object sender, EventArgs e)
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
                    catalogueCollection.RemoveAt(e.RowIndex);
                else MessageBox.Show("Se está editando datos, por favor termine la operación.");
            }
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index)
            {
                catalogueViewModel = catalogueCollection[e.RowIndex];
              
                FillFields(catalogueViewModel);
                listOperation = TransactionAction.Edit;
                btnAddUser.Text = "Actualizar";
                btnAddUser.BackColor = Color.MediumSlateBlue;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {//Si se cancela la acción establecer nulo como último registro.
            LastRecord = null;
            this.Close();
        }

        protected override void CloseForm()
        {//Si se cierra el formulario, establecer nulo como último registro.
            base.CloseForm();
            LastRecord = null;
        }
        #endregion

    }
}
