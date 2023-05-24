using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UI.WinForm.ViewModels
{
    public class CatalogueViewModel
    {
        #region -> Attributs

        private int _IdCate;
        private string _NameC;
        private string _TypeC;
        private string _AbreC;
        private int _father;
        private DateTime _CreationTime;
        private int _CreationUser;
        private DateTime _UpdateTime;
        private int _UpdateUser;

        #endregion

        #region -> Constructore

        public CatalogueViewModel() { }

        public CatalogueViewModel(int idCate, string nameCa, string typeCa, string abreviatura, int idFather, DateTime creationTime, int creationUser, DateTime updateDate, int updateUser)
        {
            CatelogueId = idCate;
            CatelogueName = nameCa;
            TypeCatatalo = typeCa;
            AbbrevitureCate = abreviatura;
            IdFather = idFather;
            CreationTime = creationTime;
            CreationUser = creationUser;
            UpdateDate = updateDate;
            UpdateUser = updateUser;
        }
        #endregion

        #region -> Propiedades + Validacíon y Visualización de Datos

        //Posición 0 
        [DisplayName("Catalogo ID")]
        public int CatelogueId {
            get { return _IdCate; }
            set { _IdCate = value; }
        }

        [DisplayName("Nombre Catalogo")]
        [Required(ErrorMessage = "El nombre de Catalogo es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de Catalogo debe contener un mínimo de 5 caracteres.")]
        public string CatelogueName { 
            get { return _NameC; } 
            set { _NameC = value; } 
        }

        [DisplayName("Tipo")]
        [Required(ErrorMessage = "El Tipo de Catalogo es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El Tipo de Catalogo debe contener un mínimo de 5 caracteres.")]
        public string TypeCatatalo
        {
            get { return _TypeC; }
            set { _TypeC = value; }
        }

        [DisplayName("Abrevitura")]
        [Required(ErrorMessage = "El Abrevitura de Catalogo es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El Abrevitura de Catalogo debe contener un mínimo de 5 caracteres.")]
        public string AbbrevitureCate {
            get { return _AbreC; }
            set { _AbreC = value; }
        }


        [DisplayName("IDpadre")]
        [Required(ErrorMessage = "El id de Catalogo es requerido.")]//Validaciones
        public int IdFather {
             get { return _father; }
             set { _father = value; }
        }

        [DisplayName("Fecha de creacion")]
        public DateTime CreationTime {
            get { return _CreationTime; }
            set { _CreationTime = value; }
        }

        [DisplayName("Usuario Creado")]
        public int CreationUser {
            get { return _CreationUser; }
            set { _CreationUser = value; }
        }

        [DisplayName("Fecha Actualizado")]
        public DateTime UpdateDate
        {
            get { return _UpdateTime; }
            set { _UpdateTime = value; }
        }

        [DisplayName("Actualizado Usuario")]
        public int UpdateUser
        {
            get { return _UpdateUser; }
            set { _UpdateUser = value; }
        }
        #endregion

        #region -> Métodos (Mapear datos)

        //Mapear modelo de dominio a modelo de vista
        public CatalogueViewModel MapCataloViewModel(CatalogueModel catalagoModel)
        {
            var catalagoViewModel = new CatalogueViewModel
            {
                CatelogueId = catalagoModel.IdCate,
                CatelogueName= catalagoModel.NameCa,
                TypeCatatalo= catalagoModel.TypeCa,
                AbbrevitureCate = catalagoModel.Abreviatura,
                IdFather = catalagoModel.FatherId,
                CreationTime = catalagoModel.CreationTime,
                CreationUser = catalagoModel.CreationUser,
                UpdateDate= catalagoModel.UpdateDate,
                UpdateUser= catalagoModel.UpdateUser
            };
            return catalagoViewModel;
        }
        public List<CatalogueViewModel> MapCataViewModel(IEnumerable<CatalogueModel> catalogueModelList)
        {
            var catalogueViewModelList = new List<CatalogueViewModel>();

            foreach (var catalogueModel in catalogueModelList)
            {
                catalogueViewModelList.Add(MapCataloViewModel(catalogueModel));
            };
            return catalogueViewModelList;
        }



        //Mapear modelo de vista a modelo de dominio
        public CatalogueModel MapCatalogueModel(CatalogueViewModel catalogueViewModel)
        {
            var catalogueModel = new CatalogueModel
            {
                IdCate = catalogueViewModel.CatelogueId,
                NameCa = catalogueViewModel.CatelogueName,
                TypeCa = catalogueViewModel.TypeCatatalo,
                Abreviatura = catalogueViewModel.AbbrevitureCate,
                FatherId = catalogueViewModel.IdFather,
                CreationTime = catalogueViewModel.CreationTime,
                CreationUser = catalogueViewModel.CreationUser,
                UpdateDate = catalogueViewModel.UpdateDate,
                UpdateUser = catalogueViewModel.UpdateUser
            };
            return catalogueModel;
        }
        public List<CatalogueModel> MapCatalogueModel(List<CatalogueViewModel> catalogueViewModelList)
        {
            var catalogueModelList = new List<CatalogueModel>();

            foreach (var catalogueViewModel in catalogueViewModelList)
            {
                catalogueModelList.Add(MapCatalogueModel(catalogueViewModel));
            };
            return catalogueModelList;
        }
        #endregion

    }
}
