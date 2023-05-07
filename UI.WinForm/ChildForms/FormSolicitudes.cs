using Domain.Models.Contracts;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.WinForm.ViewModels;
using Infra.Common;

namespace UI.WinForm.ChildForms
{
    public partial class FormSolicitudes : Form
    {
        #region -> Campos

        private ISolicitudModel domainModel = new SolicitudModel();//Modelo de dominio del Usuario.
        private SolicitudViewModel solicitudViewModel = new SolicitudViewModel();//Modelo de vista del Usuario.
        private List<SolicitudViewModel> solicitudViewList;//Lista de usuarios.
        private FormSolicitudMaintenance maintenanceForm;//formulario de mantenimiento.
        #endregion

        #region -> Constructor
        public FormSolicitudes()
        {
            InitializeComponent();
        }
        #endregion

        #region -> Métodos

        private void LoadSolicitudData()
        {//LLenar la cuadricula de datos con la lista de usuarios.
            solicitudViewList = solicitudViewModel.MapSolicitudViewModel(domainModel.GetAll());//Obtener todos los usuarios.
            dataGridView1.DataSource = solicitudViewList;//Establecer la fuente de datos.
        }
        private void FindSolicitud(string value)
        { //Buscar usuarios.           
            solicitudViewList = solicitudViewModel.MapSolicitudViewModel(domainModel.GetByValue(value));//Filtrar usuario por valor.
            dataGridView1.DataSource = solicitudViewList;//Establecer la fuente de datos con los resultados.
        }
        private SolicitudViewModel GetSolicitud(int id)
        {//Obtener solicitidud por ID.
            var solicitudModel = domainModel.GetSingle(id.ToString());//Buscar un único usuario.
            if (solicitudModel != null)//Si hay resultado, retornar un objeto modelo de vista de usuario.
                return solicitudViewModel.MapSolicitudViewModel(solicitudModel);
            else //Caso contrario, retornar un valor nulo, y mostrar mensaje.
            {
                MessageBox.Show("No se ha encontrado solicitud con id: " + id.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        #endregion

        #region -> Métodos de Eventos

        private void FormSolicitudes_Load(object sender, EventArgs e)
        {
            LoadSolicitudData();//Cargar datos.
            dataGridView1.Columns[0].Width = 30;//Establecer un ancho fijo para la columna ID.
            dataGridView1.Columns[1].Width = 70;//Establecer un ancho fijo para la columna Username.
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[3].Width = 130;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindSolicitud(txtSearch.Text);//Buscar solicitud.
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindSolicitud(txtSearch.Text);//Buscar solicitud si se presiona tecla enter en cuadro de texto buscar.
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {//Mostrar detalles de la solicitud.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var solicitud = GetSolicitud((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetUser(id).
                if (solicitud == null) return;
                var frm = new FormSolicitudMaintenance(solicitud, TransactionAction.View);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                frm.ShowDialog();//Mostrar formulario.
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {//Agregar nuevo usuario.
            maintenanceForm = new FormSolicitudMaintenance(new SolicitudViewModel(), TransactionAction.Add);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
            maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
            maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {//Editar solicitud.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var solicitud = GetSolicitud((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetUser(id).
                if (solicitud == null) return;

                maintenanceForm = new FormSolicitudMaintenance(solicitud, TransactionAction.Edit);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
                maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.            
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //private void btnRemove_Click(object sender, EventArgs e)
        //{//Eliminar solicitud.
        //    if (dataGridView1.RowCount <= 0)
        //    {
        //        MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        var solicitud = GetSolicitud((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetUser(id).
        //        if (solicitud == null) return;

        //        maintenanceForm = new FormSolicitudMaintenance(solicitud, TransactionAction.Remove);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
        //        maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
        //        maintenanceForm.ShowDialog();   //Mostrar formulario de mantenimiento.              
        //    }
        //    else
        //        MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        private void MaintenanceFormClosed(object sender, FormClosedEventArgs e)
        {//Actualizar el datagridview despues que el formualario de mantenimiento se cierre.
            var lastData = maintenanceForm.LastRecord;//Obtener el último registro del formulario de mantenimiento.
            if (lastData != null)//Si tiene un último registro.
            {
                LoadSolicitudData();//Actualizar el datagridview.
                if (lastData != "")//Si el campo último registro, es diferente a una cadena vacia, entonces debe resaltar y visualizar el usuario agregado o editado.
                {
                    //-1 no me lo encuentra //lastData = 3
                    var index = solicitudViewList.FindIndex(u => u.Id == Convert.ToInt32(lastData));//Buscar el index de la ultima solicitud registrada o modificada.
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];//Enfocar la celda del ultimo registro.
                    dataGridView1.Rows[index].Selected = true;//Seleccionar fila.
                    //Nota, si agregó varias solicitudes a la vez (Inserción masiva) se seleccionará el primer registro de la colección de solicitudes.
                }
            }
        }

        #endregion
    }
}
