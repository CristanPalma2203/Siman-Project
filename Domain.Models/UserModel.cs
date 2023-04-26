using Domain.Models.Contracts;
using Infra.DataAccess.Contracts;
using Infra.DataAccess.Entities;
using Infra.DataAccess.Repositories;
using Infra.EmailServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModel : IUserModel
    {
        /// <summary>
        /// Esta clase implementa la interfaz IUserModel junto a sus métodos definidos.
        /// </summary>

        #region -> Atributos

        private int _id;
        private string _username;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _position;
        private string _email;
        private byte[] _photo;
        private IUserRepository _userRepository;
        #endregion

        #region -> Constructores

        public UserModel()
        {
            _userRepository = new UserRepository();
        }

        public UserModel(int id, string userName, string password, string firstName, string lastName, string position, string email, byte[] photo)
        {
            Id = id;
            Username = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Email = email;
            Photo = photo;

            _userRepository = new UserRepository();
        }
        #endregion

        #region -> Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public byte[] Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        #endregion

        #region -> Métodos Públicos        

        public int Add(UserModel userModel)
        {
            var userEntity = MapUserEntity(userModel);
            return _userRepository.Add(userEntity);
        }
        public int Edit(UserModel userModel)
        {
            var userEntity = MapUserEntity(userModel);
            return _userRepository.Edit(userEntity);
        }
        public int Remove(UserModel userModel)
        {
            var userEntity = MapUserEntity(userModel);
            return _userRepository.Remove(userEntity);
        }
        public int AddRange(List<UserModel> userModels)
        {
            var userEntityList = MapUserEntity(userModels);
            return _userRepository.AddRange(userEntityList);
        }
        public int RemoveRange(List<UserModel> userModels)
        {
            var userEntityList = MapUserEntity(userModels);
            return _userRepository.RemoveRange(userEntityList);
        }

        public UserModel GetSingle(string value)
        {
            var userEntity = _userRepository.GetSingle(value);
            if (userEntity != null)
                return MapUserModel(userEntity);
            else return null;
        }
        public IEnumerable<UserModel> GetAll()
        {
            var userEntityList = _userRepository.GetAll();
            return MapUserModel(userEntityList);
        }
        public IEnumerable<UserModel> GetByValue(string value)
        {
            var userEntityList = _userRepository.GetByValue(value);
            return MapUserModel(userEntityList);
        }

        public UserModel Login(string username, string password)
        {
            var userEntity = _userRepository.Login(username, password);
            if (userEntity != null)
                return MapUserModel(userEntity);
            else return null;

        }
        public UserModel RecoverPassword(string requestingUser)
        {//Método para recupear la contraseña del usuario y enviarlo a su dirección de correo.
           var userModel= GetSingle(requestingUser);
           if (userModel != null)
           {
               var mailService = new EmailService();
               mailService.Send(
                   recipient: userModel.Email,
                   subject: "Solicitud de recuperación de contraseña",
                   body: "Hola " + userModel.FirstName + ",\nSolicitó recuperar su contraseña.\n" +
                   "Tu contraseña actual es: " + userModel.Password + "\nSin embargo, le pedimos que cambie" +
                   "su contraseña inmediatamente una vez ingrese a la aplicacíon");              
           }
           return userModel;
            /*Nota: Eso es simplemente un ejemplo para enviar correos electrónicos,
             * no es buena idea enviar directamente la contraseña del usuario,
             * en su lugar, es mejor enviar una contraseña temporal.*/
        }
        #endregion

        #region -> Métodos Privados (Mapear datos)
     
        //Mapear modelo entidad a modelo de dominio.
        private UserModel MapUserModel(User userEntity)
        {//Mapear un solo objeto.
            var userModel = new UserModel
            {
                Id = userEntity.Id,
                Username = userEntity.Username,
                Password = userEntity.Password,
                FirstName = userEntity.FirstName,
                LastName = userEntity.LastName,
                Position = userEntity.Position,
                Email = userEntity.Email,
                Photo = userEntity.Photo
            };
            return userModel;

        }
        private List<UserModel> MapUserModel(IEnumerable<User> userEntityList)
        {//Mapear colección de objetos.
            var userModelList = new List<UserModel>();

            foreach (var userEntity in userEntityList)
            {
                userModelList.Add(MapUserModel(userEntity));
            };
            return userModelList;
        }
        //Mapear modelo de dominio a modelo de entidad.
        private User MapUserEntity(UserModel userModel)
        {//Mapear un solo objeto.
            var userEntity = new User
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
            return userEntity;
        }        
        private List<User> MapUserEntity(List<UserModel> userModelList)
        {//Mapear una colección de usuarios.
            var userEntityList = new List<User>();

            foreach (var userModel in userModelList)
            {
                userEntityList.Add(MapUserEntity(userModel));
            };
            return userEntityList;
        }
        #endregion
       
    }
}
