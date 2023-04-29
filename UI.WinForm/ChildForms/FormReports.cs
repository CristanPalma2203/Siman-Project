using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Xamarin.Forms;

//IText para Reportes PDF
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Infra.DataAccess;
using Infra.DataAccess.Repositories;

namespace UI.WinForm.ChildForms
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();

            string[] tablas = { "Users", "Product" };

            for (int i = 0; i < tablas.Length; i++)
            {
                comboBox1.Items.Add(tablas[i]);
            }

            btnAdd.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBox1.SelectedItem.ToString();

            btnAdd.Text = "Generar Reporte de " + opcion;
            btnAdd.Visible = true;
        }

        private void CrearPDF(string opcion)
        {
            Reportes repo = new Reportes();

            repo.GenerarReporte(opcion);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string opcion = comboBox1.SelectedItem.ToString();

            CrearPDF(opcion);
        }
    }
}
