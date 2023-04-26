using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.WinForm.Helpers;

namespace UI.WinForm.Base
{
   public class BaseFixedForm:Form
   {
       /// <summary>
       /// Formulario prediseñado con barra de titulo, herede esta clase si desea 
       /// crear formularios fijos (Sin cambio de tamaño).
       /// </summary>

       #region -> Definición de Campos

       private DragControl dragControl;//Responsable de arrastrar el formualario.
       private Panel titleBar;//Barra de título del formulario.
       private Button btnClose;//Botón de cerrar del formulario.
       private Label lblTitle;//Título del formulario.

       #endregion

       #region -> Constructor

       public BaseFixedForm()
       {
           titleBar = new Panel();
           dragControl = new DragControl(titleBar,this);
           btnClose = new Button();
           lblTitle = new Label();

          
           titleBar.Size = new System.Drawing.Size(300,40);
           titleBar.BackColor = Color.RoyalBlue;
           titleBar.Dock = DockStyle.Top;
           titleBar.Controls.Add(btnClose);
           titleBar.Controls.Add(lblTitle);

           btnClose.Image = Properties.Resources.btnClose;
           btnClose.Size = new System.Drawing.Size(40,40);
           btnClose.Dock = DockStyle.Right;
           btnClose.Text = "";
           btnClose.FlatStyle = FlatStyle.Flat;
           btnClose.FlatAppearance.BorderSize = 0;
           btnClose.Click += new EventHandler(btnClose_Click);

           lblTitle.Text = "Fixed Form";
           lblTitle.ForeColor = Color.WhiteSmoke;
           lblTitle.Font = new Font("Verdana",11F,FontStyle.Regular);
           lblTitle.Location=new Point(10,10);
           lblTitle.AutoSize = true;

           this.Controls.Add(titleBar);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.ResizeRedraw = true;
           this.Padding = new Padding(1);
       }
       #endregion

       #region -> Definición de Propiedades

       protected Color TitleBarColor
       {
           get { return titleBar.BackColor; }
           set { titleBar.BackColor = value; }
       }
       public override string Text
       {
           get
           {
               return base.Text;
           }
           set
           {
               base.Text = value;
               lblTitle.Text = value;
           }
       }
       #endregion

       #region -> Métodos

       protected virtual void CloseForm()
       {
           this.Close();
       }
       #endregion

       #region -> Eventos

       private void btnClose_Click(object sender, EventArgs e)
       {
           CloseForm();
       }

       protected override void OnPaint(PaintEventArgs e)
       {
           base.OnPaint(e);
           e.Graphics.DrawRectangle(new Pen(Color.Gray,1), 0, 0, this.Width - 1, this.Height - 1);//Dibujar el borde del formulario.
       }
       #endregion

   }
}
