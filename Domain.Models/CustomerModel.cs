using Domain.Models.Contracts;
using Infra.DataAccess.Contracts;
using Infra.DataAccess.Entities;
using Infra.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models 
{
    public class CustomerModel : ICustomerModel
    {
        #region -> Attributos 
        private int _idcustemer;
        private string _nameCustomer;
        private int _archiId;
        private string _LastNameC;
        private string _emailC;
        private string _addressC;
        private string _phoneC;

        private ICustemerRepository _custemerRepository;
        #endregion

        #region -> Constructores

        public CustomerModel() {
            _custemerRepository = new CustemerRepository();
        }
        public CustomerModel(int idCustemer, string nameCustemer, int archiIdC, string lastNameC, string emailC, string address, string phone) {
            IdCustemer = idCustemer;
            NameCustemer = nameCustemer;
            ArchiIdC = archiIdC;
            LastName = lastNameC;
            Email = emailC;
            Address = address;
            Phone = phone;

            _custemerRepository = new CustemerRepository();
        }

        #endregion

        #region -> Propiedades
        public int IdCustemer
        {
            get { return _idcustemer; }
            set { _idcustemer = value; }
        }

        public string NameCustemer {
            get { return _nameCustomer; }
            set { _nameCustomer = value; }
        }

        public int ArchiIdC {
            get { return _archiId; }
            set { _archiId = value; }
        }

        public string LastName{
            get { return _LastNameC; }
            set{ _LastNameC = value; } 
        }

        public string Email {
            get {return _emailC;}
            set { _emailC = value;}
        }

        public string Address {
            get { return _addressC; }
            set { _addressC = value;}
        }

        public string Phone {
            get { return _phoneC; }
            set { _phoneC = value; }
        }
        #endregion

        #region -> Metodos

        public int Add(CustomerModel customerModel) {
            var custemerEntity = MapCustemerEntity(customerModel);
            return _custemerRepository.Add(custemerEntity);
        }

        public int Edit(CustomerModel customerModel) { 
            var customerEntity = MapCustemerEntity(customerModel);
            return _custemerRepository.Edit(customerEntity); 
        }

        public int Remove(CustomerModel customerModel)
        {
            var customerModelEntity = MapCustemerEntity(customerModel);
            return _custemerRepository.Remove(customerModelEntity);
        }

        public int AddRange(List<CustomerModel> customerModel) { 
            var customerEntityList = MapCustemerEntity(customerModel);
            return _custemerRepository.AddRange(customerEntityList);
        }

        public int RemoveRange(List<CustomerModel> customerModel) { 
            var customerEntity = MapCustemerEntity(customerModel);
            return _custemerRepository.RemoveRange(customerEntity);
        }

        public CustomerModel GetSingle(string value) { 
            var customerEntity = _custemerRepository.GetSingle(value);
            if (customerEntity != null) {
                return MapCustemerEntity(customerEntity);

            }else return null; 
        }

        public IEnumerable<CustomerModel> GetAll() { 
            var customerEntityLis = _custemerRepository.GetAll();
            return MapCustemerEntity(customerEntityLis);
        }

        public IEnumerable<CustomerModel> GetByValue(string value) {
            var customerEntityList = _custemerRepository.GetByValue(value);
            return MapCustemerEntity(customerEntityList);
        }

        #endregion

        #region -> Metodos Privados (Mapar datos)

        private CustomerModel MapCustemerEntity(Custemer custemerEntity) {
            var custemerModel = new CustomerModel {
                IdCustemer = custemerEntity.IdCustemer,
                NameCustemer = custemerEntity.NameCustemer,
                ArchiIdC = custemerEntity.ArchiId,
                LastName = custemerEntity.LastNameCuste,
                Email = custemerEntity.EmailCustemer,
                Address = custemerEntity.AddressCustemer,
                Phone = custemerEntity.PhoneNumber,
            };
            return custemerModel;
        }

        private List<CustomerModel> MapCustemerEntity(IEnumerable<Custemer> custemerEntityList) {
            var CustemerModelList = new List<CustomerModel>();

            foreach (var customerEntity in custemerEntityList) { 
                CustemerModelList.Add(MapCustemerEntity(customerEntity));
            };
            return CustemerModelList;
        }

        private Custemer MapCustemerEntity(CustomerModel custemerEntity)
        {
            var customer = new Custemer
            {
                IdCustemer = custemerEntity.IdCustemer,
                NameCustemer = custemerEntity.NameCustemer,
                ArchiId = custemerEntity.ArchiIdC,
                LastNameCuste = custemerEntity.LastName,
                EmailCustemer = custemerEntity.Email,
                AddressCustemer = custemerEntity.Address,
                PhoneNumber = custemerEntity.Phone,

            };

            return customer;

        }

        private List<Custemer> MapCustemerEntity(List<CustomerModel> custemerEntityList) {
            var custemerEntityLis = new List<Custemer>();

            foreach (var customer in custemerEntityList) {
                custemerEntityLis.Add(MapCustemerEntity(customer));
            };
            return custemerEntityLis;
        }
        #endregion

    }

}
