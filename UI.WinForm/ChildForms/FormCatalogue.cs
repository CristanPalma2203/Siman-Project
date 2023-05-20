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
    public partial class FormCatalogue : Form
    {
        #region -> Campos
        private ICatalogueModel domainModel = new CatalogueModel();//Modelo de dominio del Usuario.
        private CatalogueViewModel catalogueViewModel = new CatalogueViewModel();//Modelo de vista del Usuario.
        private List<CatalogueViewModel> catalogueViewList;//Lista de usuarios.
        private FormCatalogueMaintenance maintenanceForm;//formulario de mantenimiento.
        #endregion

        #region -> Constructor
        public FormCatalogue()
        {
            InitializeComponent();
        }
        #endregion

        #region -> Métodos

        private void LoadUserData()
        {//LLenar la cuadricula de datos con la lista de usuarios.
            catalogueViewList = catalogueViewModel.MapCataViewModel(domainModel.GetAll());//Obtener todos los usuarios.
            dataGridView1.DataSource = catalogueViewList;//Establecer la fuente de datos.
        }
        private void FindUser(string value)
        { //Buscar usuarios.           
            catalogueViewList = catalogueViewModel.MapCataViewModel(domainModel.GetByValue(value));//Filtrar usuario por valor.
            dataGridView1.DataSource = catalogueViewList;//Establecer la fuente de datos con los resultados.
        }
        private CatalogueViewModel GetCatalogue(int id)
        {//Obtener usuario por ID.
            var catalogueModel = domainModel.GetSingle(id.ToString());//Buscar un único usuario.
            if (catalogueModel != null)//Si hay resultado, retornar un objeto modelo de vista de usuario.
                return catalogueViewModel.MapCataloViewModel(catalogueModel);
            else //Caso contrario, retornar un valor nulo, y mostrar mensaje.
            {
                MessageBox.Show("No se ha encontrado Catalogo id: " + id.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        #endregion

        #region -> Métodos de Eventos

        private void FormCatalogue_Load(object sender, EventArgs e)
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
                var catalgoue = GetCatalogue((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (catalgoue == null) return;
                var frm = new FormCatalogueMaintenance(catalgoue, TransactionAction.View);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                frm.ShowDialog();//Mostrar formulario.
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {//Agregar nuevo usuario.
            maintenanceForm = new FormCatalogueMaintenance(new CatalogueViewModel(), TransactionAction.Add);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
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
                var user = GetCatalogue((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (user == null) return;

                maintenanceForm = new FormCatalogueMaintenance(user, TransactionAction.Edit);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
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
                var user = GetCatalogue((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (user == null) return;

                maintenanceForm = new FormCatalogueMaintenance(user, TransactionAction.Remove);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
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
                    var index = catalogueViewList.FindIndex(u => u.CatelogueName == lastData);//Buscar el index del ultimo usuario registrado o modificado.
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];//Enfocar la celda del ultimo registro.
                    dataGridView1.Rows[index].Selected = true;//Seleccionar fila.
                    //Nota, si agregó varios usuarios a la vez (Inserción masiva) se seleccionará el primer registro de la colección de usuarios.
                }
            }
        }

        #endregion

    }
}
