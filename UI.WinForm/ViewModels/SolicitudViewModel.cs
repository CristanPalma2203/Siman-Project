using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.WinForm.ViewModels
{
    public class SolicitudViewModel
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

        #endregion

        #region -> Constructores

        public SolicitudViewModel()
        {

        }

        public SolicitudViewModel(int id, int idCliente, string nombreCliente, int idUsuarioGestion, string usuarioGestion, DateTime fechaVenta, decimal totalVenta, int estadoId, string indicaciones, string observaciones)
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
        }

        #endregion

        #region Propiedades + Validacion y Visualizacion de Datos

        //Posición 0 
        [DisplayName("ID")]//Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Posición 1 
        [DisplayName("Cliente")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Id del cliente es requerido.")]//Validaciones
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        //Posición 2
        [DisplayName("Usuario Gestion")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Id del usuario en gestion es requerido")]//Valicaciones
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe contener un mínimo de 5 caracteres.")]
        public string UsuarioGestion
        {
            get { return _usuarioGestion; }
            set { _usuarioGestion = value; }
        }

        [DisplayName("Fecha Venta")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor seleccione fecha")]
        //[RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        //[StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 3 caracteres.")]
        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        [DisplayName("Total Venta")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese un total")]
        public decimal TotalVenta
        {
            get { return _totalVenta; }
            set { _totalVenta = value; }
        }
        
        [DisplayName("Estado")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese un estado")]
        public int EstadoId
        {
            get { return _estadoId; }
            set { _estadoId = value; }
        }

        [DisplayName("Indicaciones")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese una indicacion")]
        public string Indicaciones
        {
            get { return _indicaciones; }
            set { _indicaciones = value; }
        }

        [DisplayName("Observaciones")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese una observacion")]
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        #endregion

        #region -> Metodos (Mapear datos)

        //Mapear modelo de dominio a modelo de vista
        public SolicitudViewModel MapSolicitudViewModel(SolicitudModel solicitudModel)
        {
            var solicitudViewModel = new SolicitudViewModel
            {
                Id = solicitudModel.Id,
                NombreCliente = solicitudModel.NombreCliente,
                UsuarioGestion = solicitudModel.UsuarioGestion,
                FechaVenta = solicitudModel.FechaVenta,
                TotalVenta = solicitudModel.TotalVenta,
                EstadoId = solicitudModel.EstadoId,
                Indicaciones = solicitudModel.Indicaciones,
                Observaciones = solicitudModel.Observaciones,
            };
            return solicitudViewModel;
        }
        public List<SolicitudViewModel> MapSolicitudViewModel(IEnumerable<SolicitudModel> solicitudModelList)
        {
            var solicitudViewModelList = new List<SolicitudViewModel>();

            foreach (var solicitudModel in solicitudModelList)
            {
               solicitudViewModelList.Add(MapSolicitudViewModel(solicitudModel));
            };
            return solicitudViewModelList;
        }

        //Mapear modelo de vista a modelo de dominio
        public SolicitudModel MapSolicitudModel(SolicitudViewModel solicitudViewModel)
        {
            var solicitudModel = new SolicitudModel
            {
                Id = solicitudViewModel.Id,
                NombreCliente = solicitudViewModel.NombreCliente,
                UsuarioGestion = solicitudViewModel.UsuarioGestion,
                FechaVenta = solicitudViewModel.FechaVenta,
                TotalVenta = solicitudViewModel.TotalVenta,
                EstadoId = solicitudViewModel.EstadoId,
                Indicaciones = solicitudViewModel.Indicaciones,
                Observaciones = solicitudViewModel.Observaciones,
            };
            return solicitudModel;
        }
        public List<SolicitudModel> MapSolicitudModel(List<SolicitudViewModel> solicitudViewModelList)
        {
            var solicitudModelList = new List<SolicitudModel>();

            foreach (var solicitudViewModel in solicitudViewModelList)
            {
                solicitudModelList.Add(MapSolicitudModel(solicitudViewModel));
            };
            return solicitudModelList;
        }
        #endregion
    }
}
