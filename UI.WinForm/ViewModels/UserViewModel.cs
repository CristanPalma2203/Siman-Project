using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Domain.Models;

namespace UI.WinForm.ViewModels
{
    public class UserViewModel
    {
        #region -> Atributos

        private int _id;
        private string _username;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _position;
        private string _email;
        private byte[] _photo;

        #endregion

        #region -> Constructores

        public UserViewModel()
        {

        }

        public UserViewModel(int id, string userName, string password, string firstName, string lastName, string position, string email, byte[] photo)
        {
            Id = id;
            Username = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Email = email;
            Photo = photo;
        }
        #endregion

        #region -> Propiedades + Validacíon y Visualización de Datos

        //Posición 0 
        [DisplayName("Num")]//Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Posición 1 
        [DisplayName("Usuario")]//Nombre a visualizar.
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        //Posición 2
        [DisplayName("Contraseña")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización (Por ejemplo no mostrar en el datagridview).
        [Required(ErrorMessage = "Por favor ingrese una contraseña.")]//Valicaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe contener un mínimo de 5 caracteres.")]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Posición 3
        [DisplayName("Nombre")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese nombre")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 3 caracteres.")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        //Posición 4
        [DisplayName("Apellido")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese apellido.")]//Validaciones
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El apellido debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El apellido debe contener un mínimo de 3 caracteres.")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        //Posición 5
        [ReadOnly(true)]//Solo lectura.
        [DisplayName("Nombre completo")]//Nombre a visualizar.
        public string FullName
        {
            get { return _firstName + ", " + _lastName; }
        }

        //Posición 6
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Por favor ingrese un cargo.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Last name must contain a minimum of 8 characters.")]
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        //Posición 7
        [DisplayName("Email")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese correo electrónico.")]//Validaciones
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //Posición 8
        [DisplayName("Foto")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        public byte[] Photo
        {
            get { return _photo; }
            set { _photo = value; }

        }
        #endregion

        #region -> Métodos (Mapear datos)

        //Mapear modelo de dominio a modelo de vista
        public UserViewModel MapUserViewModel(UserModel userModel)
        {
            var userViewModel = new UserViewModel
            {
                Id = userModel.Id,
                Username = userModel.Username,
                Password = userModel.Password,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Position = userModel.Position,
                Email = userModel.Email,
                Photo = userModel.Photo
            };
            return userViewModel;
        }
        public List<UserViewModel> MapUserViewModel(IEnumerable<UserModel> userModelList)
        {
            var userViewModelList = new List<UserViewModel>();

            foreach (var userModel in userModelList)
            {
                userViewModelList.Add(MapUserViewModel(userModel));
            };
            return userViewModelList;
        }

        //Mapear modelo de vista a modelo de dominio
        public UserModel MapUserModel(UserViewModel userViewModel)
        {
            var userModel = new UserModel
            {
                Id = userViewModel.Id,
                Username = userViewModel.Username,
                Password = userViewModel.Password,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Position = userViewModel.Position,
                Email = userViewModel.Email,
                Photo = userViewModel.Photo
            };
            return userModel;
        }        
        public List<UserModel> MapUserModel(List<UserViewModel> userViewModelList)
        {
            var userModelList = new List<UserModel>();

            foreach (var userViewModel in userViewModelList)
            {
                userModelList.Add(MapUserModel(userViewModel));
            };
            return userModelList;
        }
        #endregion
    }
}
