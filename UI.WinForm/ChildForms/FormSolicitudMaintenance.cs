using Domain.Models;
using Domain.Models.Contracts;
using Infra.Common;
using Microsoft.SqlServer.Server;
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
    public partial class FormSolicitudMaintenance : Base.BaseFixedForm
    {
        /// <summary>
        /// Esta clase hereda de la clase BaseFixedForm.
        /// </summary>

        #region -> Definición de Campos

        private ISolicitudModel domainModel;//Interfaz del modelo de dominio Solicitud.
        private BindingList<SolicitudViewModel> solicitudCollection;//Colección de usuarios para la inserción masiva.
        private SolicitudViewModel solicitudViewModel;//Modelo de vista del usuario.
        private TransactionAction transaction;//Acción de transacción para la persistencia.
        private TransactionAction listOperation = TransactionAction.Add; //Acción de transacción para la colección de usuarios.
        private string lastRecord = "";/*Campo para almacenar el ultimo dato insertado o editado.
                                         Esto permitirá seleccionar y visualizar los cambios en el datagridview del formulario Solicitud.*/
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

        public FormSolicitudMaintenance(SolicitudViewModel _solicitudViewModel, TransactionAction _transaction)
        {
            InitializeComponent();

            //Inicializar campos
            domainModel = new SolicitudModel();
            solicitudCollection = new BindingList<SolicitudViewModel>();
            solicitudViewModel = _solicitudViewModel;
            transaction = _transaction;

            //Inicializar propiedades de control
            rbSingleInsert.Checked = true;
            dataGridView1.DataSource = solicitudCollection;
            FillFields(_solicitudViewModel);
            InitializeTransactionUI();
            InitializeDataGridView();
        }
        #endregion

        #region -> Definicion de Metodos

        private void InitializeTransactionUI()
        {//Este método es responsable de establecer las propiedades de apariencia según la acción de la transacción.
            switch (transaction)
            {
                case TransactionAction.View:
                    LastRecord = null;
                    this.TitleBarColor = Color.MediumSlateBlue;
                    lblTitle2.Text = "Detalles de la solicitud";
                    lblTitle2.ForeColor = Color.MediumSlateBlue;
                    btnSave.Visible = false;
                    panelAddedControl.Visible = false;
                    btnCancel.Text = "X  Cerrar";
                    btnCancel.Location = new Point(300, 310);
                    btnCancel.BackColor = Color.MediumSlateBlue;
                    ReadOnlyFields();
                    break;

                case TransactionAction.Add:
                    this.TitleBarColor = Color.SeaGreen;
                    lblTitle2.Text = "Agregar Solicitud";
                    lblTitle2.ForeColor = Color.SeaGreen;
                    txtFecha.Enabled = false;
                    txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); //<===== 
                    btnSave.BackColor = Color.SeaGreen;
                    break;

                case TransactionAction.Edit:
                    this.TitleBarColor = Color.RoyalBlue;
                    lblTitle2.Text = "Editar Solicitud";
                    lblTitle2.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    txtCliente.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtTotal.Enabled = false;
                    txtFecha.Enabled = false; //= FechaVenta.ToString("dd/MM/yyyy hh:mm:ss tt");
                    panelAddedControl.Visible = false;
                    break;

                case TransactionAction.Remove:
                    this.TitleBarColor = Color.IndianRed;
                    lblTitle2.Text = "Eliminar Solicitud";
                    lblTitle2.ForeColor = Color.IndianRed;
                    btnSave.Text = "Eliminar";
                    btnSave.BackColor = Color.IndianRed;
                    panelAddedControl.Visible = false;
                    ReadOnlyFields();
                    break;

                case TransactionAction.Special:
                    this.TitleBarColor = Color.RoyalBlue;
                    lblTitle2.Text = "Actualizar mi perfil de usuario";
                    lblTitle2.ForeColor = Color.RoyalBlue;
                    btnSave.BackColor = Color.RoyalBlue;
                    panelAddedControl.Visible = false;
                    lblTotal.Text = "Contraseña nueva";
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
                var solicitudObject = FillViewModel();//Obtener modelo de vista.
                var validateData = new DataValidation(solicitudObject);//Validar campos del objeto.

                if (validateData.Result == true)//Si el objeto es válido.
                {
                    var solicitudModel = solicitudViewModel.MapSolicitudModel(solicitudObject);//Mapear el modelo de vista a modelo de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add://Agregar solicitud.
                            AddSolicitud(solicitudModel);
                            break;
                        case TransactionAction.Edit://Editar solicitud.
                            EditSolicitud(solicitudModel);
                            break;
                        case TransactionAction.Remove://Eliminar v.
                            RemoveSolicitud(solicitudModel);
                            break;
                            //case TransactionAction.Special://Actualizar perfil de usuario
                            //    if (string.IsNullOrWhiteSpace(txtCurrentPass.Text) == false)
                            //    {
                            //        if (txtCurrentPass.Text == solicitudViewModel.Password)//Por seguridad, validar contraseña actual del usuario.
                            //            EditUser(solicitudModel);
                            //        else
                            //            MessageBox.Show("Tu contraseña actual es incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //    }
                            //    else
                            //        MessageBox.Show("Por favor ingrese su contraseña actual", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //    break;
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
                if (solicitudCollection.Count > 0)//Validar si hay datos a insertar.
                {
                    var solicitudModelList = solicitudViewModel.MapSolicitudModel(solicitudCollection.ToList());//Mapear la colección de usuarios a colección de modelos de dominio.
                    switch (transaction)
                    {
                        case TransactionAction.Add:
                            AddSolicitudRange(solicitudModelList);//Agregar rango de usuarios.
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

        private void AddSolicitud(SolicitudModel solicitudModel)
        {
            var result = domainModel.Add(solicitudModel);
            if (result > 0)
            {
                LastRecord = solicitudModel.NombreCliente;//Establecer el ultimo registro.
                MessageBox.Show("Solicitud agregada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void AddSolicitudRange(List<SolicitudModel> solicitudModelList)
        {
            var result = domainModel.AddRange(solicitudModelList);

            if (result > 0)
            {
                LastRecord = solicitudModelList[0].NombreCliente;//Establecer el primer objeto como ultimo registro.
                MessageBox.Show("se agregaron " + result.ToString() + " solicitudes con éxito");
                this.Close();
            }
            else
            {
                lastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void EditSolicitud(SolicitudModel solicitudModel)
        {
            var result = domainModel.Edit(solicitudModel);
            if (result > 0)
            {
                LastRecord = solicitudModel.Id.ToString();//Establecer el ultimo registro.
                MessageBox.Show("Solicitud actualizada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void RemoveSolicitud(SolicitudModel solicitudModel)
        {
            var result = domainModel.Remove(solicitudModel);
            if (result > 0)
            {
                LastRecord = "";//Establecer una cadena vacía como ultimo registro, ya que el usuario ya no existe, por lo tanto no es posible seleccionar y visualizar los cambios (Ver formulario Users).
                MessageBox.Show("Solicitud eliminada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                LastRecord = null;
                MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifySolicitudCollection()
        {//Este método es responsable de agregar o modificar un usuario de la colección de usuarios para la insercion masiva.
            var solicitudObject = FillViewModel();

            var validateData = new DataValidation(solicitudObject);//Validar objeto.

            if (validateData.Result == true)
            {
                switch (listOperation)
                {
                    case TransactionAction.Add:
                        //Valida que no se duplique el Email
                        var findSolicitud = solicitudCollection.FirstOrDefault(solicitud => solicitud.NombreCliente == solicitudObject.NombreCliente);
                        if (findSolicitud == null)
                        {
                            var lastSolicitud = solicitudCollection.LastOrDefault();
                            if (lastSolicitud == null) solicitudObject.Id = 1;
                            else solicitudObject.Id = lastSolicitud.Id + 1;

                            solicitudCollection.Add(solicitudObject);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Dato duplicado.\nEmail o nombre de usuario ya se ha añadido",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case TransactionAction.Edit:
                        var findObject = solicitudCollection.SingleOrDefault(solicitud => solicitud.Id == solicitudViewModel.Id);
                        var index = solicitudCollection.IndexOf(findObject);
                        solicitudCollection[index] = solicitudObject;

                        solicitudCollection.ResetBindings();
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

        private void FillFields(SolicitudViewModel solicitudView)
        {//Cargar los datos del modelo de vista en los campos del formulario.
            txtCliente.Text = solicitudView.NombreCliente;
            txtUsuario.Text = solicitudView.UsuarioGestion;
            txtFecha.Text = Convert.ToDateTime(solicitudView.FechaVenta).ToString("dd/MM/yyyy");
            txtTotal.Text = Convert.ToDecimal(solicitudView.TotalVenta).ToString();
            txtEstado.Text = Convert.ToInt32(solicitudView.EstadoId).ToString();
            txtIndicaciones.Text = solicitudView.Indicaciones;
            txtObservaciones.Text = solicitudView.Observaciones;
        }
        private SolicitudViewModel FillViewModel()
        {//LLenar y retornar los datos de los campos del formulario en un nuevo objeto.
            var solicitudView = new SolicitudViewModel();

            solicitudView.Id = solicitudViewModel.Id;
            solicitudView.NombreCliente = txtCliente.Text;
            solicitudView.UsuarioGestion = txtUsuario.Text;
            solicitudView.FechaVenta = Convert.ToDateTime(txtFecha.Text);
            solicitudView.TotalVenta = Convert.ToDecimal(txtTotal.Text);
            solicitudView.EstadoId = Convert.ToInt32(txtEstado.Text);
            solicitudView.Indicaciones = txtIndicaciones.Text;
            solicitudView.Observaciones = txtObservaciones.Text;

            return solicitudView;
        }
        private void ClearFields()
        {//Limpiar los campos del formulario.
            txtUsuario.Clear();
            txtTotal.Clear();
            txtCliente.Clear();
            txtFecha.Clear();
            txtEstado.Clear();
            txtIndicaciones.Clear();
            txtObservaciones.Clear();

            listOperation = TransactionAction.Add;
            btnAddSolicitud.Text = "Agregar";
            btnAddSolicitud.BackColor = Color.CornflowerBlue;
        }

        private void ReadOnlyFields()
        {//Convertir los campos del formulario en solo lectura.
            txtUsuario.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtCliente.ReadOnly = true;
            txtFecha.ReadOnly = true;
            txtEstado.ReadOnly = true;
            txtIndicaciones.ReadOnly = true;
            txtObservaciones.ReadOnly = true;
        }

        #endregion

        #region -> Definicion de metodos de evento

        private void btnSave_Click(object sender, EventArgs e)
        {//Boton guardar cambios

            if (rbSingleInsert.Checked) //Si el botón de radio está activado.
                PersistSingleRow();//Ejecutar el método de persistir una sola fila.
            else //Caso contrario, ejecutar el método de persistir varias filas(Insercción masiva)
                PersistMultipleRows();
        }
        private void btnAddSolicitudList_Click(object sender, EventArgs e)
        {//Botón de agregar usuario a la colección de usuarios para la insercción masiva.
            ModifySolicitudCollection();
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
                    solicitudCollection.RemoveAt(e.RowIndex);
                else MessageBox.Show("Se está editando datos, por favor termine la operación.");
            }
            if (e.ColumnIndex == dataGridView1.Columns["EditColumn"].Index)
            {
                solicitudViewModel = solicitudCollection[e.RowIndex];
                FillFields(solicitudViewModel);
                listOperation = TransactionAction.Edit;
                btnAddSolicitud.Text = "Actualizar";
                btnAddSolicitud.BackColor = Color.MediumSlateBlue;
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
