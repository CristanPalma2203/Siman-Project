using Domain.Models.Contracts;
using Infra.DataAccess.Contracts;
using Infra.DataAccess.Entities;
using Infra.DataAccess.Repositories;
using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class CatalogueModel : ICatalogueModel
    {
        #region -> Atributos

        private int _idCatalogue;
        private string _nameC;
        private string _TypeCaC;
        private string _AbrevC;
        private int _FatherC;
        private DateTime _CreationTimeC;
        private int _UsuerIDC;
        private DateTime _UpdateDateC;
        private int _UpdateUserC;
   
        private ICatalogueRepository _CatalgoueRepository;
        #endregion

        #region -> Constructores
        public CatalogueModel()
        {
            _CatalgoueRepository = new CatalogueRepository();
        }

        public CatalogueModel(int idCate, string nameCa,string abreviaturaC, string typeCa, int idFather, DateTime creationTime, int creationUser, DateTime updateDate, int updateUser)
        {
            IdCate = idCate;
            NameCa = nameCa;
            Abreviatura = abreviaturaC;
            TypeCa = typeCa;
            FatherId = idFather;
            CreationTime = creationTime;
            CreationUser = creationUser;
            UpdateDate = updateDate;
            UpdateUser = updateUser;

            _CatalgoueRepository = new CatalogueRepository();
        }

        #endregion

        #region -> Propiedades
        
        public int IdCate { 
            get { return _idCatalogue; } 
            set { _idCatalogue = value; } 
        }

        public string NameCa {
            get { return _nameC; }
            set { _nameC = value; }
        }

        public string Abreviatura {
            get { return _AbrevC; }
            set { _AbrevC = value; }
        }

        public string TypeCa {
            get { return _TypeCaC; }
            set { _TypeCaC = value; }
        }

        public int FatherId {
            get { return _FatherC; }
            set { _FatherC = value; }
        }

        public DateTime CreationTime {
            get { return _CreationTimeC; }
            set { _CreationTimeC = value; }
        }

        public int CreationUser
        {
            get { return _UsuerIDC; }
            set { _UsuerIDC = value; }
        }

        public DateTime UpdateDate
        {
            get { return _UpdateDateC; }
            set { _UpdateDateC = value; }
        }

        public int UpdateUser
        {
            get { return _UpdateUserC; }
            set { _UpdateUserC = value; }
        }

        #endregion


        #region -> Metodos
        public int Add(CatalogueModel catalogueModel)
        {
            var productEntity = MapCatalogueEntity(catalogueModel);
            return _CatalgoueRepository.Add(productEntity);
        }
        public int Edit(CatalogueModel catalogueModel)
        {
            var catalogueEntity = MapCatalogueEntity(catalogueModel);
            return _CatalgoueRepository.Edit(catalogueEntity);
        }
        public int Remove(CatalogueModel catalogueModel)
        {
            var catalogueModelEntity = MapCatalogueEntity(catalogueModel);
            return _CatalgoueRepository.Remove(catalogueModelEntity);
        }
        public int AddRange(List<CatalogueModel> catalogueModel)
        {
            var cataloguEntityList = MapCatalogueEntity(catalogueModel);
            return _CatalgoueRepository.AddRange(cataloguEntityList);
        }
        public int RemoveRange(List<CatalogueModel> producModel)
        {
            var catalogueEntityList = MapCatalogueEntity(producModel);
            return _CatalgoueRepository.RemoveRange(catalogueEntityList);
        }

        public CatalogueModel GetSingle(string value)
        {
            var catalogueEntity = _CatalgoueRepository.GetSingle(value);
            if (catalogueEntity != null)  
                return MapCatalogueEntity(catalogueEntity);
            else return null;
        }
        public IEnumerable<CatalogueModel> GetAll()
        {
            var catalogueEntityList = _CatalgoueRepository.GetAll();
            return MapCatalogueEntity(catalogueEntityList);
        }
        public IEnumerable<CatalogueModel> GetByValue(string value)
        {
            var producEntityList = _CatalgoueRepository.GetByValue(value);
            return MapCatalogueEntity(producEntityList);
        }


        #endregion

        #region -> Métodos Privados (Mapear datos)

        //Mapear modelo entidad a modelo de dominio.
        private CatalogueModel MapCatalogueEntity(Catalogue catalogueEntity)
        {//Mapear un solo objeto.
            var catalogueModel = new CatalogueModel
            {
                IdCate = catalogueEntity.CatalogueID,
                NameCa = catalogueEntity.CatalogueName,
                TypeCa = catalogueEntity.Cataloguetype,
                Abreviatura = catalogueEntity.CatalogueAbbreviation,
                FatherId = catalogueEntity.CatalogueFatherID,
                CreationTime = catalogueEntity.CatalogueCreationDate,
                CreationUser= catalogueEntity.CatalogueCreationUser,
                UpdateDate = catalogueEntity.CatalogueUpdateDate,
                UpdateUser = catalogueEntity.CatalogueUpdateUser,
            };
            return catalogueModel;

        }
        private List<CatalogueModel> MapCatalogueEntity(IEnumerable<Catalogue> CatalogueEntityList)
        {//Mapear colección de objetos.
            var CatalogueModelList = new List<CatalogueModel>();

            foreach (var catalogueEnty in CatalogueEntityList)
            {
                CatalogueModelList.Add(MapCatalogueEntity(catalogueEnty));
            };
            return CatalogueModelList;
        }
        //Mapear modelo de dominio a modelo de entidad.
        private Catalogue MapCatalogueEntity(CatalogueModel catalogueEntity)
        {//Mapear un solo objeto.
            var catalogue = new Catalogue
            {
                CatalogueID = catalogueEntity.IdCate,
                CatalogueName = catalogueEntity.NameCa,
                Cataloguetype = catalogueEntity.TypeCa,
                CatalogueAbbreviation = catalogueEntity.Abreviatura,
                CatalogueFatherID = catalogueEntity.FatherId,
                CatalogueCreationDate = catalogueEntity.CreationTime,
                CatalogueCreationUser = catalogueEntity.CreationUser,
                CatalogueUpdateDate = catalogueEntity.UpdateDate,
                CatalogueUpdateUser = catalogueEntity.UpdateUser,
            };
            return catalogue;
        }
        private List<Catalogue> MapCatalogueEntity(List<CatalogueModel> catalogueEntityList)
        {//Mapear una colección de Product.
            var catalogueEntityLis = new List<Catalogue>();

            foreach (var catalogueModel in catalogueEntityList)
            {
                catalogueEntityLis.Add(MapCatalogueEntity(catalogueModel));
            };
            return catalogueEntityLis;
        }


        #endregion

     
    }
}
