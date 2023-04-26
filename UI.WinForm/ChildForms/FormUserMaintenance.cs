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
    public partial class FormUserMaintenance : Base.BaseFixedForm
    {
        /// <summary>
        /// Esta clase hereda de la clase BaseFixedForm.
        /// </summary>

        #region -> Definición de Campos

        private IUserModel domainModel;//Interfaz del modelo de dominio Usuario.
        private BindingList<UserViewModel> userCollection;//Colección de usuarios para la inserción masiva.
        private UserViewModel userViewModel;//Modelo de vista del usuario.
        private TransactionAction transaction;//Acción de transacción para la persistencia.
        private TransactionAction listOperation = TransactionAction.Add; //Acción de transacción para la colección de usuarios.
        private Image defaultPhoto = Properties.Resources.defaultImageProfileUser;//Foto predeterminada para usuarios que no tienen una foto agregada.
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

        public FormUserMaintenance(UserViewModel _userViewModel, TransactionAction _transaction)
        {
            InitializeComponent();

            //Inicializar campos
            domainModel = new UserModel();
            userCollection = new BindingList<UserViewModel>();
            userViewModel = _userViewModel;
            transaction = _transaction;

            //Inicializar propiedades de control
            rbSingleInsert.Checked = true;
            cmbPosition.DataSource = Positions.GetPositions();
            dataGridView1.DataSource = userCollection;
            FillFields(_userViewModel);
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
                    lblTitle.Text = "Detalles de usuario";
                    lblTitle.ForeColor = Color.MediumSlateBlue;
                    btnSave.Visible = false;
                    panelAddedControl.Visible = false;
                    lblCurrentPass.Visible = false;
                    txtCurrentPass.Visible = false;
                    lblConfirmPass.Visible = false;
                    txtConfirmPass.Visible = false;
                    btnCancel.Text = "X  Cerrar";
                    btnCancel.Location = new Point(300, 310);
                    btnCancel.BackColor = Color.MediumSlateBlue;
                    ReadOnlyFields();
                    break;

                case TransactionAction.Add:
                    this.TitleBarColor = Color.SeaGreen;
                    lblTitle.Text = "Agregar usuario";
                    lblTitle.ForeColor = Color.SeaGreen;
                    btnSave.BackColor = Color.SeaGreen;
                    cmbPosition.SelectedIndex = -1;
                    lblCurrentPass.Visible = false;
                    txtCurrentPass.Visible = false;
                    break;

                case TransactionAction.Edit:
                    this.TitleBarColor = Color.RoyalBlue;
                    lblTitle.Text = "Editar usuario";
                    lblTitle.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    panelAddedControl.Visible = false;
                    lblCurrentPass.Visible = false;
                    txtCurrentPass.Visible = false;
                    break;

                case TransactionAction.Remove:
                    this.TitleBarColor = Color.IndianRed;
                    lblTitle.Text = "Eliminar usuario";
                    lblTitle.ForeColor = Color.IndianRed;
                    btnSave.Text = "Eliminar";
                    btnSave.BackColor = Color.IndianRed;
                    panelAddedControl.Visible = false;
                    lblCurrentPass.Visible = false;
                    txtCurrentPass.Visible = false;
                    ReadOnlyFields();
                    break;

                case TransactionAction.Special:
                    this.TitleBarColor = Color.RoyalBlue;
                    lblTitle.Text = "Actualizar mi perfil de usuario";
                    lblTitle.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    panelAddedControl.Visible = false;
                    lblPassword.Text = "Contraseña nueva";
					cmbPosition.Enabled = false;
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
                var userObject = FillViewModel();//Obtener modelo de vista.
                var validateData = new DataValidation(userObject);//Validar campos del objeto.
                var validatePassword = txtPassword.Text == txtConfirmPass.Text;//Validar contraseñas.

                if (validateData.Result == true && validatePassword == true)//Si el objeto es válido.
                {
                    var userModel = userViewModel.MapUserModel(userObject);//Mapear el modelo de vista a modelo de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add://Agregar usuario.
                            AddUser(userModel);
                            break;
                        case TransactionAction.Edit://Editar usuario.
                            EditUser(userModel);
                            break;
                        case TransactionAction.Remove://Eliminar usuario.
                            RemoveUser(userModel);
                            break;
                        case TransactionAction.Special://Actualizar perfil de usuario
                            if (string.IsNullOrWhiteSpace(txtCurrentPass.Text)==false)
                            {
                                if (txtCurrentPass.Text == userViewModel.Password)//Por seguridad, validar contraseña actual del usuario.
                                    EditUser(userModel);
                                else
                                    MessageBox.Show("Tu contraseña actual es incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                                
                            }
                            else
                                MessageBox.Show("Por favor ingrese su contraseña actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                                                    
                            break;
                    }
                }

                else
                {
                    if (validateData.Result == false)
                        MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (userCollection.Count > 0)//Validar si hay datos a insertar.
                {
                    var userModelList = userViewModel.MapUserModel(userCollection.ToList());//Mapear la colección de usuarios a colección de modelos de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add:
                            AddUserRange(userModelList);//Agregar rango de usuarios.
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
        private void AddUser(UserModel userModel)
        {
            var result = domainModel.Add(userModel);
            if (result > 0)
            {
                LastRecord = userModel.Username;//Establecer el ultimo registro.
                MessageBox.Show("Usuario agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void AddUserRange(List<UserModel> userModelList)
        {
            var result = domainModel.AddRange(userModelList);

            if (result > 0)
            {
                LastRecord = userModelList[0].Username;//Establecer el primer objeto como ultimo registro.
                MessageBox.Show("se agregaron " + result.ToString() + " usuarios con éxito");
                this.Close();
            }
            else
            {
                lastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void EditUser(UserModel userModel)
        {
            var result = domainModel.Edit(userModel);
            if (result > 0)
            {
                LastRecord = userModel.Username;//Establecer el ultimo registro.
                MessageBox.Show("Usuario actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void RemoveUser(UserModel userModel)
        {
            var result = domainModel.Remove(userModel);
            if (result > 0)
            {
                LastRecord = "";//Establecer una cadena vacía como ultimo registro, ya que el usuario ya no existe, por lo tanto no es posible seleccionar y visualizar los cambios (Ver formulario Users).
                MessageBox.Show("Usuario eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifyUserCollection()
        {//Este método es responsable de agregar o modificar un usuario de la colección de usuarios para la insercion masiva.
            var userObject = FillViewModel();

            var validateData = new DataValidation(userObject);//Validar objeto.
            var validatePassword = txtPassword.Text == txtConfirmPass.Text;

            if (validateData.Result == true && validatePassword == true)
            {
                switch (listOperation)
                {
                    case TransactionAction.Add:
                        var findUser = userCollection.FirstOrDefault(user => user.Email == userObject.Email
                                                                   || user.Username == userObject.Username);
                        if (findUser == null)
                        {
                            var lastUser = userCollection.LastOrDefault();
                            if (lastUser == null) userObject.Id = 1;
                            else userObject.Id = lastUser.Id + 1;

                            userCollection.Add(userObject);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Dato duplicado.\nEmail o nombre de usuario ya se ha añadido",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case TransactionAction.Edit:
                        var findObject = userCollection.SingleOrDefault(user => user.Id == userViewModel.Id);
                        var index = userCollection.IndexOf(findObject);
                        userCollection[index] = userObject;

                        userCollection.ResetBindings();
                        ClearFields();
                        break;
                }

            }
            else
            {
                if (validateData.Result == false)
                    MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FillFields(UserViewModel userView)
        {//Cargar los datos del modelo de vista en los campos del formulario.
            txtUsername.Text = userView.Username;
            txtPassword.Text = userView.Password;
            txtConfirmPass.Text = userView.Password;
            txtFirstName.Text = userView.FirstName;
            txtLastName.Text = userView.LastName;
            cmbPosition.Text = userView.Position;
            txtEmail.Text = userView.Email;
            if (userView.Photo != null)
                PictureBoxPhoto.Image = ItemConverter.BinaryToImage(userView.Photo);
            else PictureBoxPhoto.Image = defaultPhoto;
        }
        private UserViewModel FillViewModel()
        {//LLenar y retornar los datos de los campos del formulario en un nuevo objeto.
            var userView = new UserViewModel();

            userView.Id = userViewModel.Id;
            userView.Username = txtUsername.Text;
            userView.Password = txtPassword.Text;
            userView.FirstName = txtFirstName.Text;
            userView.LastName = txtLastName.Text;
            userView.Position = cmbPosition.Text;
            userView.Email = txtEmail.Text;
            if (PictureBoxPhoto.Image == defaultPhoto)
                userView.Photo = null;
            else userView.Photo = ItemConverter.ImageToBinary(PictureBoxPhoto.Image);

            return userView;
        }

        private void ClearFields()
        {//Limpiar los campos del formulario.
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            txtCurrentPass.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            PictureBoxPhoto.Image = defaultPhoto;
            cmbPosition.SelectedIndex = -1;

            listOperation = TransactionAction.Add;
            btnAddUser.Text = "Agregar";
            btnAddUser.BackColor = Color.CornflowerBlue;
        }
        private void ReadOnlyFields()
        {//Convertir los campos del formulario en solo lectura.
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtConfirmPass.ReadOnly = true;
            txtCurrentPass.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            btnAddPhoto.Enabled = false;
            btnDeletePhoto.Enabled = false;
            cmbPosition.Enabled = false;
        }
        #endregion

        #region -> Definición de métodos de evento

        private void btnSave_Click(object sender, EventArgs e)
        {//Boton guardar cambios

            if (rbSingleInsert.Checked) //Si el botón de radio está activado.
                PersistSingleRow();//Ejecutar el método de persistir una sola fila.
            else //Caso contrario, ejecutar el método de persistir varias filas(Insercción masiva)
                PersistMultipleRows();
        }
        private void btnAddUserList_Click(object sender, EventArgs e)
        {//Botón de agregar usuario a la colección de usuarios para la insercción masiva.
            ModifyUserCollection();
        }

        private void FormUserMaintenance_Load(object sender, EventArgs e)
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

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {//Agregar una imagen al cuadro de imagen para la foto del usuario.
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureBoxPhoto.Image = new Bitmap(openFile.FileName);
            }
        }
        private void btnDeletePhoto_Click(object sender, EventArgs e)
        {//Borrar foto del usuario
            PictureBoxPhoto.Image = defaultPhoto;
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
                    userCollection.RemoveAt(e.RowIndex);
                else MessageBox.Show("Se está editando datos, por favor termine la operación.");
            }
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index)
            {
                userViewModel = userCollection[e.RowIndex];
                FillFields(userViewModel);
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
