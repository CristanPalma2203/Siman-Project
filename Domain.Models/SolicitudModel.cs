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
    public class SolicitudModel : ISolicitudModel
    {

        #region -> Atributos

        private int _id;
        private int _idCliente;
        private string _nombreCliente;
        private int _idUsuarioGestion;
        private string _usuarioGestion;
        private DateTime _fechaVenta;
        private decimal _totalVenta;
        private int _estadoId;
        private string _indicaciones;
        private string _observaciones;
        private SolicitudRepository _solicitudRepository;

        #endregion

        #region -> Constructores

        public SolicitudModel()
        {
            _solicitudRepository = new SolicitudRepository();
        }

        public SolicitudModel(int id, int idCliente, string nombreCliente, int idUsuarioGestion, string usuarioGestion, DateTime fechaVenta, decimal totalVenta, int estadoId, string indicaciones, string observaciones)
        {
            _id = id;
            _idCliente = idCliente;
            _nombreCliente = nombreCliente;
            _idUsuarioGestion = idUsuarioGestion;
            _usuarioGestion = usuarioGestion;
            _fechaVenta = fechaVenta;
            _totalVenta = totalVenta;
            _estadoId = estadoId;
            _indicaciones = indicaciones;
            _observaciones = observaciones;

            _solicitudRepository = new SolicitudRepository();
        }

        #endregion

        #region -> Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        public int IdUsuarioGestion
        {
            get { return _idUsuarioGestion; }
            set { _idUsuarioGestion = value; }
        }

        public string UsuarioGestion
        {
            get { return _usuarioGestion; }
            set { _usuarioGestion = value; }
        }

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        public decimal TotalVenta
        {
            get { return _totalVenta; }
            set { _totalVenta = value; }
        }

        public int EstadoId
        {
            get { return _estadoId; }
            set { _estadoId = value; }
        }

        public string Indicaciones
        {
            get { return _indicaciones; }
            set{ _indicaciones = value; }
        }

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        #endregion

        #region -> Metodos Publicos

        public int Add(SolicitudModel solicitudModel)
        {
            var solicitudEntity = MapSolicitudEntity(solicitudModel);
            return _solicitudRepository.Add(solicitudEntity);
        }
        public int Edit(SolicitudModel solicitudModel)
        {
            var solicitudEntity = MapSolicitudEntity(solicitudModel);
            return _solicitudRepository.Edit(solicitudEntity);
        }
        public int Remove(SolicitudModel solicitudModel)
        {
            var solicitudEntity = MapSolicitudEntity(solicitudModel);
            return _solicitudRepository.Remove(solicitudEntity);
        }

        //Aun no he creado metodos Range en el repositorio

        public int AddRange(List<SolicitudModel> solicitudModels)
        {
            //var solicitudEntity = MapSolicitudEntity(solicitudModels);
            //return _solicitudRepository.AddRange(solicitudEntity);
            return 0;
        }

        public int RemoveRange(List<SolicitudModel> solicitudModels)
        {
            //var solicitudEntityList = MapSolicitudEntity(solicitudModels);
            //return _solicitudRepository.RemoveRange(solicitudEntityList);
            return 0;
        }

        public IEnumerable<SolicitudModel> GetAll()
        {
            var solicitudEntityList = _solicitudRepository.GetAll();
            return MapSolicitudModel(solicitudEntityList);
        }

        public IEnumerable<SolicitudModel> GetByValue(string value)
        {
            var solicitudEntityList = _solicitudRepository.GetByValue(value);
            return MapSolicitudModel(solicitudEntityList);
        }

        public SolicitudModel GetSingle(string value)
        {
            var solicitudEntity = _solicitudRepository.GetSingle(value);
            if (solicitudEntity != null)
                return MapSolicitudModel(solicitudEntity);
            else return null;
        }

        #endregion

        #region -> Metodo Privados (Mapear datos)

        //Mapear modelo entidad a modelo de dominio.
        private SolicitudModel MapSolicitudModel(Solicitud solicitudEntity)
        {//Mapear un solo objeto.
            var solicitudModel = new SolicitudModel
            {
                Id = solicitudEntity.Id,
                IdCliente = solicitudEntity.IdCliente,
                NombreCliente = solicitudEntity.NombreCliente,
                IdUsuarioGestion = solicitudEntity.IdUsuarioGestion,
                UsuarioGestion = solicitudEntity.UsuarioGestion,
                FechaVenta = solicitudEntity.FechaVenta,
                TotalVenta = solicitudEntity.TotalVenta,
                EstadoId = solicitudEntity.EstadoId,
                Indicaciones = solicitudEntity.Indicaciones,
                Observaciones = solicitudEntity.Observaciones,
            };
            return solicitudModel;

        }
        private List<SolicitudModel> MapSolicitudModel(IEnumerable<Solicitud> solicitudEntityList)
        {//Mapear colección de objetos.
            var solicitudModelList = new List<SolicitudModel>();

            foreach (var solicitudEntity in solicitudEntityList)
            {
                solicitudModelList.Add(MapSolicitudModel(solicitudEntity));
            };
            return solicitudModelList;
        }
        //Mapear modelo de dominio a modelo de entidad.
        private Solicitud MapSolicitudEntity(SolicitudModel solicitudModel)
        {//Mapear un solo objeto.
            var solicitudEntity = new Solicitud
            {
                Id = solicitudModel.Id,
                IdCliente = solicitudModel.IdCliente,
                NombreCliente = solicitudModel.NombreCliente,
                IdUsuarioGestion = solicitudModel.IdUsuarioGestion,
                UsuarioGestion = solicitudModel.UsuarioGestion,
                FechaVenta = solicitudModel.FechaVenta,
                TotalVenta = solicitudModel.TotalVenta,
                EstadoId = solicitudModel.EstadoId,
                Indicaciones = solicitudModel.Indicaciones,
                Observaciones = solicitudModel.Observaciones,
            };
            return solicitudEntity;
        }
        private List<Solicitud> MapSolicitudEntity(List<SolicitudModel> solicitudModelList)
        {//Mapear una colección de solicitudes.
            var solicitudEntityList = new List<Solicitud>();

            foreach (var solicitudModel in solicitudModelList)
            {
                solicitudEntityList.Add(MapSolicitudEntity(solicitudModel));
            };
            return solicitudEntityList;
        }

        #endregion
    }
}
