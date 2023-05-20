using Domain.Models;
using Domain.ValueObjects;
using Infra.DataAccess.Entities;
using Infra.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI.WinForm.ViewModels
{
    public class CustomerViewModel 
    {
        #region -> Attributos 

        private int _id;
        private string _name;
        private int _archiId;
        private string _emailC;
        private string _phoneC;
        private string _addressC;
        private string _LastNameC;

        #endregion

        #region -> Constructores
        public CustomerViewModel() {
        }

        public CustomerViewModel(int idCustemer, string nameCustemer1, int archiIdC, string lastNameC, string emailC, string address, string phone)
        {
            IdCustemer = idCustemer;
            NameCustemer = nameCustemer1;
            ArchiIdC = archiIdC;
            LastName = lastNameC;
            Email = emailC;
            Address = address;
            Phone = phone;

        }

        #endregion

        #region -> Propiedades + Validacíon y Visualización de Datos
        [DisplayName("Codigo")]
        public int IdCustemer {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Por favor ingrese Nombre")]//Validaciones
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Nombre debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Nombre debe contener un mínimo de 3 caracteres.")]
        public string NameCustemer
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Codigo Archivo")]
        [Required(ErrorMessage = "Por favor ingrese Codigo")]//Validaciones
        public int ArchiIdC
        {
            get { return _archiId; }
            set { _archiId = value; }
        }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "Por favor ingrese Apellido")]//Validaciones
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Apellido debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Apellido debe contener un mínimo de 3 caracteres.")]
        public string LastName
        {
            get { return _LastNameC; }
            set { _LastNameC = value; }
        }


        [DisplayName("Email")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese correo electrónico.")]//Validaciones
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido")]
        public string Email
        {
            get { return _emailC; }
            set { _emailC = value; }
        }

        [DisplayName("Dirrecion")]
        [Required(ErrorMessage = "Por favor ingrese Dirrecion")]//Validaciones
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El Dirrecion debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Dirrecion debe contener un mínimo de 3 caracteres.")]
        public string Address
        {
            get { return _addressC; }
            set { _addressC = value; }
        }

        [DisplayName("Telefono")]
        [Required(ErrorMessage = "Por favor ingrese Dirrecion")]//Validaciones
        [RegularExpression("^[1-9]+$", ErrorMessage = "El Dirrecion debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El Dirrecion debe contener un mínimo de 3 caracteres.")]

        public string Phone
        {
            get { return _phoneC; }
            set { _phoneC = value; }
        }

        #endregion

        #region -> Métodos (Mapear datos)
        public CustomerViewModel MapCustomerVideModel(CustomerModel customermodel) {
            var customerVierModel = new CustomerViewModel
            {
                IdCustemer = customermodel.IdCustemer,
                NameCustemer = customermodel.NameCustemer,
                ArchiIdC = customermodel.ArchiIdC,
                LastName = customermodel.LastName,
                Email = customermodel.Email,
                Address = customermodel.Address,
                Phone = customermodel.Phone,
            };
            return customerVierModel;
        }

        public List<CustomerViewModel> MapCustomerVideModel(IEnumerable<CustomerModel> customerModelList) { 
         var customerViewModels = new List<CustomerViewModel>();
            foreach (var customerModel in customerModelList)
            {
                customerViewModels.Add(MapCustomerVideModel(customerModel));
            };
            return customerViewModels;
        }

        //Mapear modelo de vista a modelo de dominio

        public CustomerModel MapCustomerModel(CustomerViewModel customerViewModel) {
            var customerMoeder = new CustomerModel{ 
               IdCustemer=customerViewModel.IdCustemer,
               NameCustemer=customerViewModel.NameCustemer,
               ArchiIdC =customerViewModel.ArchiIdC,
               LastName = customerViewModel.LastName,
               Email = customerViewModel.Email,
               Address = customerViewModel.Address,
               Phone = customerViewModel.Phone,
            };
            return customerMoeder;
        }

        public List<CustomerModel> MapCustomerModel(List<CustomerViewModel> customerViewModelList)
        {
            var customerModelList = new List<CustomerModel>();

            foreach (var customerViewModel in customerViewModelList) {
                customerModelList.Add(MapCustomerModel(customerViewModel));
            };

            return customerModelList;
        }

        #endregion

    }
}
