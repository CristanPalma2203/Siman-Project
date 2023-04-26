using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI.WinForm.Helpers
{
    public class DragControl
    {
        #region -> Fields Definition

        private Control dragControl;
        private Form targetForm;
        #endregion

        #region -> Constructors

        public DragControl(Control _dragControl, Form _targetForm)
        {
            targetForm = _targetForm;
            dragControl = _dragControl;
            dragControl.MouseDown += new MouseEventHandler(Control_MouseDown);
        }

        #endregion

        #region -> Import Extern Methods

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region -> Event Methods Definition

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();//Releases the mouse capture from a window            
            SendMessage(targetForm.Handle, 0x112, 0xf012, 0);//Send message to a window         
        }
        #endregion
    }
}
