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
    public partial class FormUsers : Form
    {
        #region -> Campos

        private IUserModel domainModel = new UserModel();//Modelo de dominio del Usuario.
        private UserViewModel userViewModel = new UserViewModel();//Modelo de vista del Usuario.
        private List<UserViewModel> userViewList;//Lista de usuarios.
        private FormUserMaintenance maintenanceForm;//formulario de mantenimiento.
        #endregion

        #region -> Constructor

        public FormUsers()
        {
            InitializeComponent();            
        }
        #endregion

        #region -> Métodos

        private void LoadUserData()
        {//LLenar la cuadricula de datos con la lista de usuarios.
            userViewList= userViewModel.MapUserViewModel(domainModel.GetAll());//Obtener todos los usuarios.
            dataGridView1.DataSource = userViewList;//Establecer la fuente de datos.
        }
        private void FindUser(string value)
        { //Buscar usuarios.           
            userViewList = userViewModel.MapUserViewModel(domainModel.GetByValue(value));//Filtrar usuario por valor.
            dataGridView1.DataSource = userViewList;//Establecer la fuente de datos con los resultados.
        }
        private UserViewModel GetUser(int id)
        {//Obtener usuario por ID.
            var userModel = domainModel.GetSingle(id.ToString());//Buscar un único usuario.
            if (userModel != null)//Si hay resultado, retornar un objeto modelo de vista de usuario.
                return userViewModel.MapUserViewModel(userModel);
            else //Caso contrario, retornar un valor nulo, y mostrar mensaje.
            {
                MessageBox.Show("No se ha encontrado usuario con id: " + id.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        #endregion

        #region -> Métodos de Eventos

        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadUserData();//Cargar datos.
            dataGridView1.Columns[0].Width = 50;//Establecer un ancho fijo para la columna ID.
            dataGridView1.Columns[1].Width = 100;//Establecer un ancho fijo para la columna Username.
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindUser(txtSearch.Text);//Buscar usuario.
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindUser(txtSearch.Text);//Buscar usuario si se preciona tecla enter en cuadro de texto buscar.
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {//Mostrar detalles de usuario.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var user = GetUser((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (user == null) return;
                var frm = new FormUserMaintenance(user, TransactionAction.View);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                frm.ShowDialog();//Mostrar formulario.
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {//Agregar nuevo usuario.
            maintenanceForm = new FormUserMaintenance(new UserViewModel(), TransactionAction.Add);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
            maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
            maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.
         
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {//Editar usuario.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var user = GetUser((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (user == null) return;

                maintenanceForm = new FormUserMaintenance(user, TransactionAction.Edit);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
                maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.            
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {//Eliminar usuario.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var user = GetUser((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (user == null) return;

                maintenanceForm = new FormUserMaintenance(user, TransactionAction.Remove);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
                maintenanceForm.ShowDialog();   //Mostrar formulario de mantenimiento.              
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MaintenanceFormClosed(object sender, FormClosedEventArgs e)
        {//Actualizar el datagridview despues que el formualario de mantenimiento se cierre.
            var lastData = maintenanceForm.LastRecord;//Obtener el último registro del formulario de mantenimiento.
            if (lastData != null)//Si tiene un último registro.
            {
                LoadUserData();//Actualizar el datagridview.
                if (lastData != "")//Si el campo último registro, es diferente a una cadena vacia, entonces debe resaltar y visualizar el usuario agregado o editado.
                {
                    var index = userViewList.FindIndex(u=>u.Username==lastData);//Buscar el index del ultimo usuario registrado o modificado.
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];//Enfocar la celda del ultimo registro.
                    dataGridView1.Rows[index].Selected = true;//Seleccionar fila.
                    //Nota, si agregó varios usuarios a la vez (Inserción masiva) se seleccionará el primer registro de la colección de usuarios.
                }
            }
        }

        #endregion


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
