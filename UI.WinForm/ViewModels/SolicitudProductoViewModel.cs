using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace UI.WinForm.ViewModels
{
    public class SolicitudProductoViewModel
    {
        #region -> Atributos

        private int _id;
        private int _idSolicitud;
        private int _idProducto;
        private int _cantidad;
        private decimal _subTotal;

        #endregion

        #region -> Constructores

        public SolicitudProductoViewModel()
        {

        }

        public SolicitudProductoViewModel(int id, int idSolicitud, int idProducto, int cantidad, decimal subTotal)
        {
            _id = id;
            _idSolicitud = idSolicitud;
            _idProducto = idProducto;
            _cantidad = cantidad;
            _subTotal = subTotal;
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
        [DisplayName("Id Solicitud")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Id del cliente es requerido.")]//Validaciones
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public int IdSolicitud
        {
            get { return _idSolicitud; }
            set { _idSolicitud = value; }
        }

        //Posición 2
        [DisplayName("Id Producto")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Id del usuario en gestion es requerido")]//Valicaciones
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe contener un mínimo de 5 caracteres.")]
        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        [DisplayName("Cantidad")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor seleccione fecha")]
        //[RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        //[StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 3 caracteres.")]
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        [DisplayName("SubTotal")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese un total")]
        public decimal SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        #endregion

        #region -> Metodos (Mapear datos)

        //Mapear modelo de dominio a modelo de vista
        public SolicitudProductoViewModel MapSolicitudProductoViewModel(SolicitudProductoModel solicitudProductoModel)
        {
            var solicitudProductoViewModel = new SolicitudProductoViewModel
            {
                Id = solicitudProductoModel.Id,
                IdSolicitud = solicitudProductoModel.IdSolicitud,
                IdProducto = solicitudProductoModel.IdProducto,
                Cantidad = solicitudProductoModel.Cantidad,
                SubTotal = solicitudProductoModel.SubTotal,
            };
            return solicitudProductoViewModel;
        }
        public List<SolicitudProductoViewModel> MapSolicitudProductoViewModel(IEnumerable<SolicitudProductoModel> solicitudProductoModelList)
        {
            var solicitudProductoViewModelList = new List<SolicitudProductoViewModel>();

            foreach (var solicitudProductoModel in solicitudProductoModelList)
            {
                solicitudProductoViewModelList.Add(MapSolicitudProductoViewModel(solicitudProductoModel));
            };
            return solicitudProductoViewModelList;
        }

        //Mapear modelo de vista a modelo de dominio
        public SolicitudProductoModel MapSolicitudProductoModel(SolicitudProductoViewModel solicitudProductoViewModel)
        {
            var solicitudProductoModel = new SolicitudProductoModel
            {
                Id = solicitudProductoViewModel.Id,
                IdSolicitud = solicitudProductoViewModel.IdSolicitud,
                IdProducto = solicitudProductoViewModel.IdProducto,
                Cantidad = solicitudProductoViewModel.Cantidad,
                SubTotal = solicitudProductoViewModel.SubTotal,
            };
            return solicitudProductoModel;
        }
        public List<SolicitudProductoModel> MapSolicitudProductoModel(List<SolicitudProductoViewModel> solicitudProductoViewModelList)
        {
            var solicitudProductoModelList = new List<SolicitudProductoModel>();

            foreach (var solicitudProductoViewModel in solicitudProductoViewModelList)
            {
                solicitudProductoModelList.Add(MapSolicitudProductoModel(solicitudProductoViewModel));
            };
            return solicitudProductoModelList;
        }
        #endregion
    }
}
