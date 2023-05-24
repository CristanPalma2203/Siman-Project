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
using UI.WinForm.Utils;
using UI.WinForm.ViewModels;

namespace UI.WinForm.ChildForms
{
    public partial class FormProductMaintenance : Base.BaseFixedForm
    {
        #region -> Definición de Campos
        
        private IProductModel domainModel;//Interfaz del modelo de dominio Usuario.
        private BindingList<ProductViewModel> productCollection;//Colección de usuarios para la inserción masiva.
        private ProductViewModel productViewModel;//Modelo de vista del usuario.
        private TransactionAction transaction;//Acción de transacción para la persistencia.
        private TransactionAction listOperation = TransactionAction.Add; //Acción de transacción para la colección de usuarios.
        private Image defaultPhoto = Properties.Resources.defultProduct;//Foto predeterminada para usuarios que no tienen una foto agregada.
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

        public FormProductMaintenance(ProductViewModel _producViewModel, TransactionAction _transaction)
        {
            InitializeComponent();

            //Inicializar campos
            domainModel = new ProductModel();
            productCollection = new BindingList<ProductViewModel>();
            productViewModel = _producViewModel;
            transaction = _transaction;

            //Inicializar propiedades de control
            rbSingleInsert.Checked = true;
            dataGridView1.DataSource = productCollection;
            FillFields(_producViewModel);
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
                    lbltitle1.Text = "Detalles de Productos";
                    lbltitle1.ForeColor = Color.MediumSlateBlue;
                    btnSave.Visible = false;
                    panelAddedControl.Visible = false;
                   
                    txtProductColor.Visible = true;
                    btnCancel.Text = "X  Cerrar";
                    btnCancel.Location = new Point(300, 310);
                    btnCancel.BackColor = Color.MediumSlateBlue;
                    ReadOnlyFields();
                    break;

                case TransactionAction.Add:
                    this.TitleBarColor = Color.SeaGreen;
                    lbltitle1.Text = "Agregar Productos";
                    lbltitle1.ForeColor = Color.SeaGreen;
                    btnSave.BackColor = Color.SeaGreen;
                    break;

                case TransactionAction.Edit:
                    this.TitleBarColor = Color.RoyalBlue;
                    lbltitle1.Text = "Editar Productos";
                    lbltitle1.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    panelAddedControl.Visible = false;

                    break;

                case TransactionAction.Remove:
                    this.TitleBarColor = Color.IndianRed;
                    lbltitle1.Text = "Eliminar Productos";
                    lbltitle1.ForeColor = Color.IndianRed;
                    btnSave.Text = "Eliminar";
                    btnSave.BackColor = Color.IndianRed;
                    panelAddedControl.Visible = false;

                    ReadOnlyFields();
                    break;

                case TransactionAction.Special:
                    this.TitleBarColor = Color.RoyalBlue;
                    lbltitle1.Text = "Actualizar mi Productos";
                    lbltitle1.ForeColor = Color.RoyalBlue;
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

        private void PersistMultipleRows()
        {//Método para persistir varias filas en la base de datos (Inserción masiva).
            try
            {
                if (productCollection.Count > 0)//Validar si hay datos a insertar.
                {
                    var productModelList = productViewModel.MapProducModel(productCollection.ToList());//Mapear la colección de usuarios a colección de modelos de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add:
                            AddProductRange(productModelList);//Agregar rango de usuarios.
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
        private void AddProduct(ProductModel productModel)
        {
            var result = domainModel.Add(productModel);
            if (result > 0)
            {
                LastRecord = productModel.ProductName;//Establecer el ultimo registro.
                MessageBox.Show("Producto agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AddProductRange(List<ProductModel> productModeList)
        {
            var result = domainModel.AddRange(productModeList);

            if (result > 0)
            {
                LastRecord = productModeList[0].ProductName;//Establecer el primer objeto como ultimo registro.
                MessageBox.Show("se agregaron " + result.ToString() + " producto con éxito");
                this.Close();
            }
            else
            {
                lastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void EditProduct(ProductModel productModel)
        {
            var result = domainModel.Edit(productModel);
             
            if (result > 0)
            {
                LastRecord = productModel.ProductName;//Establecer el ultimo registro.
                MessageBox.Show("Producto actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RemoveProduct(ProductModel productModel)
        {
            var result = domainModel.Remove(productModel);
            if (result > 0)
            {
                LastRecord = "";//Establecer una cadena vacía como ultimo registro, ya que el usuario ya no existe, por lo tanto no es posible seleccionar y visualizar los cambios (Ver formulario Users).
                MessageBox.Show("Product eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifyProductCollection()
        {//Este método es responsable de agregar o modificar un usuario de la colección de usuarios para la insercion masiva.
            var productObject = FillViewModel();


            switch (listOperation)
            {
                case TransactionAction.Add:
                    var findUser = productCollection.FirstOrDefault(user => user.ProductName == productObject.ProductDescription
                                                               || user.ProductName == productObject.ProductDescription);
                    if (findUser == null)
                    {
                        var lastUser = productCollection.LastOrDefault();
                        if (lastUser == null) productObject.ProductId = 1;
                        else productObject.ProductId = lastUser.ProductId + 1;

                        productCollection.Add(productObject);
                        ClearFields();
                    }

                    break;

                case TransactionAction.Edit://catalogueViewModel
                    var findObject = productCollection.SingleOrDefault(user => user.ProductId == productViewModel.ProductId);
                    var index = productCollection.IndexOf(findObject);
                    productCollection[index] = productObject;

                    productCollection.ResetBindings();
                    ClearFields();
                    break;
            }



        }

        private void FillFields(ProductViewModel productView)
        {//Cargar los datos del modelo de vista en los campos del formulario.
            txtNameProduc.Text = productView.ProductSize;
            txtDescrip.Text = productView.ProductDescription;
            txtprice.Text = productView.ProductPrice.ToString();
            txtProductSize.Text = productView.ProductSize;
            txtProductColor.Text = productView.ProductColor;
            txtCantidadPro.Text = productView.ProductStock.ToString();
            if (productView.ProductPhoto != null)
             PictureBoxPhoto.Image = ItemConverter.BinaryToImage(productView.ProductPhoto);
            else PictureBoxPhoto.Image = defaultPhoto;
        }
        private ProductViewModel FillViewModel()
        {//LLenar y retornar los datos de los campos del formulario en un nuevo objeto.
            var productModel = new ProductViewModel();

            productModel.ProductId = productViewModel.ProductId;
            productModel.ProductName = txtNameProduc.Text;
            productModel.ProductDescription = txtDescrip.Text;
            productModel.ProductPrice = Convert.ToDouble(txtprice.Text);
            productModel.ProductSize = txtProductSize.Text;
            productModel.ProductColor = txtProductColor.Text;
            productModel.ProductStock = Convert.ToInt32(txtCantidadPro.Text);
          if (PictureBoxPhoto.Image == defaultPhoto)
                         productModel.ProductPhoto = null;
            else productModel.ProductPhoto = ItemConverter.ImageToBinary(PictureBoxPhoto.Image);

            return productModel;
        }

        private void ClearFields()
        {//Limpiar los campos del formulario.
            txtNameProduc.Clear();
            txtDescrip.Clear();
            txtCantidadPro.Clear();
            txtprice.Clear();
            txtProductSize.Clear();
            txtProductColor.Clear();
            PictureBoxPhoto.Image = defaultPhoto;

            listOperation = TransactionAction.Add;
            btnAddUser.Text = "Agregar";
            btnAddUser.BackColor = Color.CornflowerBlue;
        }
        private void ReadOnlyFields()
        {//Convertir los campos del formulario en solo lectura.
            txtNameProduc.ReadOnly = true;
            txtDescrip.ReadOnly = true;
            txtCantidadPro.ReadOnly = true;
            txtprice.ReadOnly = true;
            txtProductSize.ReadOnly = true;
            txtProductColor.ReadOnly = true;
            btnAddPhoto.Enabled = false;
            btnDeletePhoto.Enabled = false;
        }
        #endregion

        private void PersistSingleRow()
        {//Método para persistir una sola fila en la base de datos.
            try
            {
                var productObject = FillViewModel();//Obtener modelo de vista

                var productModel = productViewModel.MapProducModel(productObject);//Mapear el modelo de vista a modelo de dominio.
                switch (transaction)
                {
                    case TransactionAction.Add://Agregar producto.
                        AddProduct(productModel);
                        break;
                    case TransactionAction.Edit://Editar producto.
                        EditProduct(productModel);
                        break;
                    case TransactionAction.Remove://Eliminar producto.
                        RemoveProduct(productModel);
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

    

        private void FormProductMaintenance_Load(object sender, EventArgs e)
        {

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
                    productCollection.RemoveAt(e.RowIndex);
                else MessageBox.Show("Se está editando datos, por favor termine la operación.");
            }
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index)
            {
                productViewModel = productCollection[e.RowIndex];
                FillFields(productViewModel);
                listOperation = TransactionAction.Edit;
                btnAddUser.Text = "Actualizar";
                btnAddUser.BackColor = Color.MediumSlateBlue;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ModifyProductCollection();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureBoxPhoto.Image = new Bitmap(openFile.FileName);
            }
        }

        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {
            PictureBoxPhoto.Image = defaultPhoto;
        }
    }
}
