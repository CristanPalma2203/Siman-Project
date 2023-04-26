using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm.ChildForms
{
    public partial class FormRecoverPassword : Base.BaseFixedForm
    {
        public FormRecoverPassword()
        {
            InitializeComponent();
            lblMessage.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) == false)
            {
                var result = new Domain.Models.UserModel().RecoverPassword(txtUser.Text);
                if (result != null)
                {
                    lblMessage.Text = "Hola, " + result.FirstName +
                       ",\nSe envió la recuperación de contraseña a su correo electrónico: " +
                       result.Email + "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez ingrese a la aplicacíon.";
                    lblMessage.ForeColor = Color.DimGray;
                }
                else
                {
                    lblMessage.Text = "Lo sentimos, no tiene una cuenta asociada con el correo electrónico o el nombre de usuario proporcionado.";
                    lblMessage.ForeColor = Color.IndianRed;
                }
            }
            else
            {
                lblMessage.Text = "Por favor ingrese su nombre de usuario o email";
                lblMessage.ForeColor = Color.IndianRed;
            }
        }
    }
}
