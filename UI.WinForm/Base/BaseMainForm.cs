using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm.Base
{
    public class BaseMainForm:Form
    {
        /// <summary>
        /// Esta clase hereda de la clase Form de la librería de windows form.
        /// Esta clase es responsable de implementar el método de redimencionamiento
        /// (Cambiar de tamaño el formualario desde la esquina inferior derecha), Minimizar, 
        /// Cerrar, Maximizar y restaurar.
        /// </summary>

        #region -> Campos

        private int tolerance = 12;//Tolerancia para el redimencionamiento.
        private const int WM_NCHITTEST = 0x0084;//Win32, Notificación de entrada del mouse: determina qué parte de la ventana corresponde a un punto, permite cambiar el tamaño del formulario.        
        private const int WS_MINIMIZEBOX = 0x20000;//Métodos nativos: representa un estilo de ventana que tiene un botón de minimizar
        private const int HTBOTTOMRIGHT = 17;//Esquina inferior derecha del borde de una ventana, permite cambiar el tamaño en diagonal hacia la derecha.
        private Rectangle sizeGripRectangle;//Control de tamaño en la esquina inferior derecha de una ventana.
        protected Panel PanelClientArea;//Area de cliente del formulario.
        #endregion

        #region -> Constructor

        public BaseMainForm()
        {
            this.Padding = new Padding(1);
            PanelClientArea = new Panel();
            PanelClientArea.BackColor = Color.WhiteSmoke;
            PanelClientArea.Dock = DockStyle.Fill;
            this.Controls.Add(PanelClientArea);
        }
        #endregion

        #region -> Métodos anulados

        protected override void WndProc(ref Message m)
        {//Función WindowProc: anulación del procesamiento de mensajes de Windows / nivel de sistema operativo
            
                switch (m.Msg)
                {
                    case WM_NCHITTEST://Si el mensaje de Windows es WM_NCHITTEST
                        base.WndProc(ref m);
                        if (this.WindowState == FormWindowState.Normal)//Cambiar el tamaño del formulario si está en estado normal.
                        {
                            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                            if (sizeGripRectangle.Contains(hitPoint))
                                m.Result = new IntPtr(HTBOTTOMRIGHT);//Cambiar el tamaño en diagonal hacia la derecha.
                        }
                        break;
                    default:
                        base.WndProc(ref m);
                        break;
                }
            
        }
        protected override void OnSizeChanged(EventArgs e)
        {//Este evento ocurre cuando el formualario cambia de tamaño.
            base.OnSizeChanged(e);
            //Crear una region con el tamaño del formulario.
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            //Crear nuevo rectángulo para el control de tamaño con las dimensiones del formulario menos el valor de la tolerencia(Coordenada) y de tamaño de la tolerancia (12px).
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);//Excluir una porcion de la región para el control de tamaño.
            this.PanelClientArea.Region = region;//Establecer la region creada.
            this.Invalidate();//Redibujar el formulario.
        }
        protected override void OnPaint(PaintEventArgs e)
        {//Este evento ocurre cuando se dibuja o redibuja el formulario.
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush blueBrush = new SolidBrush(Color.WhiteSmoke);
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);//Dibujar un rectangulo relleno en las coordenadas del control de tamaño.
            ControlPaint.DrawSizeGrip(e.Graphics, Color.WhiteSmoke, sizeGripRectangle);//Dibujar el control de tamaño(lineas diagonales)
            e.Graphics.DrawRectangle(new Pen(Color.RoyalBlue), 0, 0, this.Width - 1, this.Height - 1);//Dibujar el borde del formulario.
        }

        protected override CreateParams CreateParams
        {//Anular los parámetros de creación de formularios
            get
            {
                CreateParams param = base.CreateParams;
                param.Style |= WS_MINIMIZEBOX; //Establece un cuadro de minimizar en el estilo de la ventana / Permitirá minimizar el formulario desde el icono de la barra de tareas.
                return param;
            }
        }
        #endregion

        #region -> Métodos

        protected void Minimize()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        protected void MaximizeRestore()
        {
            if (this.WindowState == FormWindowState.Normal)//Maximizar el formulario
            {
                /*Al maximizar un formulario sin bordes, éste cubre toda la pantalla ocultando la barra de tareas,
                 * para ello es necesario especificar un tamaño máximo:*/
                this.MaximumSize = Screen.FromHandle(this.Handle).WorkingArea.Size;//Establecer el tamaño del área del escritorio como el tamaño máximo del formulario.
                this.WindowState = FormWindowState.Maximized;
                this.Padding = new Padding(0);//Ocultar el borde.
            }
            else//Restaurar eltamaño del formualario.
            {
                this.WindowState = FormWindowState.Normal;
                this.Padding = new Padding(1);//Mostrar el borde.
            } 
        }
        protected void CloseApp() 
        {
            if (MessageBox.Show("¿Está seguro de cerrar la aplicación?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();//Cierra toda la aplicación finalizando todos los procesos.
        }
        #endregion

    }
}
