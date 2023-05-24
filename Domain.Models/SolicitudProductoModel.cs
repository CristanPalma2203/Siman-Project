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
    public class SolicitudProductoModel : ISolicitudProductoModel
    {
        #region -> Atributos
        private int _id;
        private int _idSolicitud;
        private int _idProducto;
        private int _cantidad;
        private decimal _subTotal;
        private SolicitudProductoRepository _solicitudProductoRepository;
        #endregion

        #region -> Constructores
        public SolicitudProductoModel()
        {
            _solicitudProductoRepository = new SolicitudProductoRepository();
        }

        public SolicitudProductoModel(int id, int idSolicitud, int idProducto, int cantidad, decimal subTotal)
        {
            _id = id;
            _idSolicitud = idSolicitud;
            _idProducto = idProducto;
            _cantidad = cantidad;
            _subTotal = subTotal;

            _solicitudProductoRepository = new SolicitudProductoRepository();
        }
        #endregion

        #region -> Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public int IdSolicitud
        {
            get { return _idSolicitud; }
            set { _idSolicitud = value; }
        }

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public decimal SubTotal
        { 
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        #endregion

        #region -> Metodos publicos

        public int Edit(SolicitudProductoModel solicitudProductoModel)
        {
            var solicitudProductoEntity = MapSolicitudProductoEntity(solicitudProductoModel);
            return _solicitudProductoRepository.Edit(solicitudProductoEntity);
        }
        public IEnumerable<SolicitudProductoModel> GetAll()
        {
            var solicitudProductoEntityList = _solicitudProductoRepository.GetAll();
            return MapSolicitudProductoModel(solicitudProductoEntityList);
        }

        public IEnumerable<SolicitudProductoModel> GetByValue(string value)
        {
            var solicitudProductoEntityList = _solicitudProductoRepository.GetByValue(value);
            return MapSolicitudProductoModel(solicitudProductoEntityList);
        }

        public SolicitudProductoModel GetSingle(string value)
        {
            var solicitudEntity = _solicitudProductoRepository.GetSingle(value);
            if (solicitudEntity != null)
                return MapSolicitudProductoModel(solicitudEntity);
            else return null;
        }
        public int AddRange(List<SolicitudProductoModel> solicitudesProducto)
        {
            throw new NotImplementedException();
        }

        public int Add(SolicitudProductoModel model)
        {
            throw new NotImplementedException();
        }

        public int Remove(SolicitudProductoModel model)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region -> Metodo privados (Mapear dato)

        //Mapear modelo entidad a modelo de dominio.
        private SolicitudProductoModel MapSolicitudProductoModel(SolicitudProducto solicitudProductoEntity)
        {//Mapear un solo objeto.
            var solicitudProductoModel = new SolicitudProductoModel
            {
                Id = solicitudProductoEntity.Id,
                IdSolicitud = solicitudProductoEntity.IdSolicitud,
                IdProducto = solicitudProductoEntity.IdProducto,
                Cantidad = solicitudProductoEntity.Cantidad,
                SubTotal = solicitudProductoEntity.SubTotal
            };

            return solicitudProductoModel;

        }
        private List<SolicitudProductoModel> MapSolicitudProductoModel(IEnumerable<SolicitudProducto> solicitudProductoEntityList)
        {//Mapear colección de objetos.
            var solicitudProductoModelList = new List<SolicitudProductoModel>();

            foreach (var solicitudEntity in solicitudProductoEntityList)
            {
                solicitudProductoModelList.Add(MapSolicitudProductoModel(solicitudEntity));
            };
            return solicitudProductoModelList;
        }
        //Mapear modelo de dominio a modelo de entidad.
        private SolicitudProducto MapSolicitudProductoEntity(SolicitudProductoModel solicitudProductoModel)
        {//Mapear un solo objeto.
            var solicitudProductoEntity = new SolicitudProducto
            {
                Id = solicitudProductoModel.Id,
                IdSolicitud = solicitudProductoModel.IdSolicitud,
                IdProducto = solicitudProductoModel.IdProducto,
                Cantidad = solicitudProductoModel.Cantidad,
                SubTotal = solicitudProductoModel.SubTotal
            };
            return solicitudProductoEntity;
        }
        private List<SolicitudProducto> MapSolicitudProductoEntity(List<SolicitudProductoModel> solicitudProductoModelList)
        {//Mapear una colección de solicitudes.
            var solicitudProductoEntityList = new List<SolicitudProducto>();

            foreach (var solicitudProductoModel in solicitudProductoModelList)
            {
                solicitudProductoEntityList.Add(MapSolicitudProductoEntity(solicitudProductoModel));
            };
            return solicitudProductoEntityList;
        }

        #endregion
    }
}
