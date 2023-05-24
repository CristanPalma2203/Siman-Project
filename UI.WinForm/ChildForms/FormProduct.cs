using Domain.Models.Contracts;
using Domain.Models;
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
using UI.WinForm.ViewModels;

namespace UI.WinForm.ChildForms
{
    public partial class FormProduct : Form
    {
        #region -> Campos
     

        private IProductModel domainModel = new ProductModel();//Modelo de dominio del Product.
        private ProductViewModel producViewModel = new ProductViewModel();//Modelo de vista del Product.
        private List<ProductViewModel> producViewList;//Lista de Product.
        private FormProductMaintenance maintenanceForm;//formulario de mantenimiento.

        #endregion
      
        #region -> Métodos

        private void LoadProducData()
        {//LLenar la cuadricula de datos con la lista de Produc.

            producViewList = producViewModel.MapProductViewModel(domainModel.GetAll());//Obtener todos los Produc.
            dataGridView1.DataSource = producViewList;//Establecer la fuente de datos.

        }
        private void FindProduct(string value)
        { //Buscar Producto.           
            producViewList = producViewModel.MapProductViewModel(domainModel.GetByValue(value));//Filtrar usuario por valor.
            dataGridView1.DataSource = producViewList;//Establecer la fuente de datos con los resultados.
        }
        private ProductViewModel GetProduct(int id)
        {//Obtener Producto por ID.
            var productModel = domainModel.GetSingle(id.ToString());//Buscar un único Producto.
            if (productModel != null)//Si hay resultado, retornar un objeto modelo de vista de Producto.
                return producViewModel.MapProViewModel(productModel);
            else //Caso contrario, retornar un valor nulo, y mostrar mensaje.
            {
                MessageBox.Show("No se ha encontrado Producto con id: " + id.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        #endregion

        #region -> Métodos de Eventos


        
        private void MaintenanceFormClosed(object sender, FormClosedEventArgs e)
        {//Actualizar el datagridview despues que el formualario de mantenimiento se cierre.
            var lastData = maintenanceForm.LastRecord;//Obtener el último registro del formulario de mantenimiento.
            if (lastData != null)//Si tiene un último registro.
            {
                LoadProducData();//Actualizar el datagridview.
                if (lastData != "")//Si el campo último registro, es diferente a una cadena vacia, entonces debe resaltar y visualizar el usuario agregado o editado.
                {
                    var index = producViewList.FindIndex(u => u.ProductName == lastData);//Buscar el index del ultimo usuario registrado o modificado.
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];//Enfocar la celda del ultimo registro.
                    dataGridView1.Rows[index].Selected = true;//Seleccionar fila.
                    //Nota, si agregó varios usuarios a la vez (Inserción masiva) se seleccionará el primer registro de la colección de usuarios.
                }
            }
        }
        #endregion

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducData();//Cargar datos.
            dataGridView1.Columns[0].Width = 50;//Establecer un ancho fijo para la columna ID.
            dataGridView1.Columns[1].Width = 100;//Establecer un ancho fijo para la columna Producto.
        }

        private void NewProduct_Click_1(object sender, EventArgs e)
        {
            maintenanceForm = new FormProductMaintenance(new ProductViewModel(), TransactionAction.Add);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
            maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
            maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.

        }

        private void ActualizarProduct_Click_1(object sender, EventArgs e)
        {
           
                //Editar Producto.
                if (dataGridView1.RowCount <= 0)
                {
                    MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dataGridView1.SelectedCells.Count > 1)
                {
                    var product = GetProduct((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                    if (product == null) return;

                    maintenanceForm = new FormProductMaintenance(product, TransactionAction.Edit);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                    maintenanceForm.FormClosed += new FormClosedEventHandler(MaintenanceFormClosed);//Asociar evento cerrado, para actualizar el datagrdiview despues que el formualario de mantenimiento se cierre.
                    maintenanceForm.ShowDialog();//Mostrar formulario de mantenimiento.            
                }
                else
                    MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void EleminarProduct_Click_1(object sender, EventArgs e)
        {
            //Eliminar Product.
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var product = GetProduct((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario y buscar usando el método GetCustomer(id).
                if (product == null) return;

                maintenanceForm = new FormProductMaintenance(product, TransactionAction.Remove);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
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
                var product = GetProduct((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del Producto y buscar usando el método GetCustomer(id).
                if (product == null) return;
                var frm = new FormProductMaintenance(product, TransactionAction.View);//Instanciar formulario, y enviar parámetros (modelo de vista y acción).
                frm.ShowDialog();//Mostrar formulario.
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindProduct(txtSearch.Text);//Buscar solicitud si se presiona tecla enter en cuadro de texto buscar.
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            FindProduct(txtSearch.Text);//Buscar Product.
        }


    }
}
