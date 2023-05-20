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
    public partial class FormCustomer : Form
    {
        #region -> Campos
        private ICustomerModel domainModel = new CustomerModel();//Modelo de dominio del Usuario.
        private CustomerViewModel customerViewModel = new CustomerViewModel();//Modelo de vista del Usuario.
        private List<CustomerViewModel> customerViewList;//Lista de usuarios.
        private FormCustomerMaintenance maintenanceForm;//formulario de mantenimiento.
        #endregion

        #region -> Constructor
        public FormCustomer()
        {
            InitializeComponent();
        }
        #endregion


        #region -> Métodos

        private void LoadCustomerData()
        {//LLenar la cuadricula de datos con la lista de usuarios.
            customerViewList = customerViewModel.MapCustomerVideModel(domainModel.GetAll());//Obtener todos los usuarios.
            dataGridView1.DataSource = customerViewList;//Establecer la fuente de datos.
        }
        private void FindCustomer(string value)
        { //Buscar usuarios.           
            customerViewList = customerViewModel.MapCustomerVideModel(domainModel.GetByValue(value));//Filtrar usuario por valor.
            dataGridView1.DataSource = customerViewList;//Establecer la fuente de datos con los resultados.
        }
        private CustomerViewModel GetCustomer(int id)
        {//Obtener usuario por ID.
            var catalogueModel = domainModel.GetSingle(id.ToString());//Buscar un único usuario.
            if (catalogueModel != null)//Si hay resultado, retornar un objeto modelo de vista de usuario.
                return customerViewModel.MapCustomerVideModel(catalogueModel);
            else //Caso contrario, retornar un valor nulo, y mostrar mensaje.
            {
                MessageBox.Show("No se ha encontrado Cliente id: " + id.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        #endregion

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();//Cargar datos.
            dataGridView1.Columns[0].Width = 50;//Establecer un ancho fijo para la columna ID.
            dataGridView1.Columns[1].Width = 100;
        }

        private void NewCustomer_Click(object sender, EventArgs e)
        {
            maintenanceForm = new FormCustomerMaintenance(new CustomerViewModel(), TransactionAction.Add);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
            maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
            maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.

        }




        private void MaintenanceFormClosed(object sender, FormClosedEventArgs e)
        {//Actualizar el datagridview despues que el formualario de mantenimiento se cierre.
            var lastData = maintenanceForm.LastRecord;//Obtener el último registro del formulario de mantenimiento.
            if (lastData != null)//Si tiene un último registro.
            {
                LoadCustomerData();//Actualizar el datagridview.
                if (lastData != "")//Si el campo último registro, es diferente a una cadena vacia, entonces debe resaltar y visualizar el usuario agregado o editado.
                {
                    var index = customerViewList.FindIndex(u => u.NameCustemer == lastData);//Buscar el index del ultimo usuario registrado o modificado.
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];//Enfocar la celda del ultimo registro.
                    dataGridView1.Rows[index].Selected = true;//Seleccionar fila.
                    //Nota, si agregó varios usuarios a la vez (Inserción masiva) se seleccionará el primer registro de la colección de usuarios.
                }
            }
        }

        private void ActualizarCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var customer = GetCustomer((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (customer == null) return;

                maintenanceForm = new FormCustomerMaintenance(customer, TransactionAction.Edit);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
                maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.            
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void EleminarCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var customer = GetCustomer((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (customer == null) return;

                maintenanceForm = new FormCustomerMaintenance(customer, TransactionAction.Remove);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
                maintenanceForm.ShowDialog();   //Mostrar formulario de mantenimiento.              
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var catalgoue = GetCustomer((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (catalgoue == null) return;
                var frm = new FormCustomerMaintenance(catalgoue, TransactionAction.View);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                frm.ShowDialog();//Mostrar formulario.
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindCustomer(txtSearch.Text);//Buscar usuario si se preciona tecla enter en cuadro de texto buscar.
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            FindCustomer(txtSearch.Text);//Buscar Cliente.
        }
    }
}
