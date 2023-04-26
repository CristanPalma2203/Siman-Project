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
    public partial class FormUserProfile : Form
    {
        UserViewModel connectedUser;
        MainForm mainForm;

        public FormUserProfile(UserViewModel _connectedUser, MainForm parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
            connectedUser = _connectedUser;
            if (connectedUser != null)
                LoadUserData();
            else btnEdit.Visible = false;
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {

        }
        private void LoadUserData()
        {
            lblFullname.Text = connectedUser.FullName;
            lblUsername.Text = connectedUser.Username;
            lblName.Text = connectedUser.FirstName;
            lblLastName.Text = connectedUser.LastName;
            lblMail.Text = connectedUser.Email;
            lblPosition.Text = connectedUser.Position;
            if (connectedUser.Photo != null)
                pictureBoxPhoto.Image = Utils.ItemConverter.BinaryToImage(connectedUser.Photo);
            else pictureBoxPhoto.Image = Properties.Resources.defaultImageProfileUser;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var userForm = new FormUserMaintenance(connectedUser,TransactionAction.Special);
            userForm.ShowDialog();
            RefreshUserData();
        }

        public void RefreshUserData()
        {
            var userModel = new Domain.Models.UserModel()
                .GetSingle(connectedUser.Id.ToString());
          
            connectedUser.FirstName = userModel.FirstName;
            connectedUser.LastName = userModel.LastName;
            connectedUser.Email = userModel.Email;
            connectedUser.Position = userModel.Position;
            connectedUser.Username = userModel.Username;
            connectedUser.Password = userModel.Password;
            connectedUser.Photo = userModel.Photo;

            LoadUserData();
            mainForm.LoadUserData();
        }
    }
}
