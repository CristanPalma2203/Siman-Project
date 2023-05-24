using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.WinForm.ViewModels
{
    public class ProductViewModel
    {
        #region -> Atributos

        private int _idPr;
        private string _nameP;
        private string _descriptionP;
        private double _priceP;
        private string _SizeP;
        private string _ColorP;
        private int _StockP;
        private byte[] _PhotoP;

        #endregion

        #region -> Contructures
        public ProductViewModel() { }

        public ProductViewModel(int productId, string productName, string productDescription, double productPrice, string productSize, string productColor, int productStock, byte[] productPhoto)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductSize = productSize;
            ProductColor = productColor;
            ProductStock = productStock;
            ProductPhoto = productPhoto;

        }
        #endregion

        #region -> Propiedades + Validacíon y Visualización de Datos

        //Posición 0 
        [DisplayName("ProductId")]//Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
        public int ProductId
        {
            get { return _idPr; }
            set { _idPr = value; }
        }

        //Posición 1 
        [DisplayName("Nombre")]//Nombre a visualizar.
        [Required(ErrorMessage = "El nombre de Producto es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string ProductName
        {
            get { return _nameP; }
            set { _nameP = value; }
        }

        //Posición 2
        [DisplayName("Descripcion")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Descripcion de Producto es requerido.")]//Validaciones

        public string ProductDescription
        {
            get { return _descriptionP; }
            set { _descriptionP = value; }
        }

        //Posición 3
        [DisplayName("Precio")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Precio de Producto es requerido.")]//Validaciones

        public double ProductPrice
        {
            get { return _priceP; }
            set { _priceP = value; }
        }

        //Posición 4
        [DisplayName("Color")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Color de Producto es requerido.")]//Validaciones

        public string ProductColor
        {
            get { return _ColorP; }
            set { _ColorP = value; }
        }

        //Posición 5
        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "Por favor ingrese un Cantidad Producto.")]
        public int ProductStock
        {
            get { return _StockP; }
            set { _StockP = value; }
        }

        //Posición 6
        [DisplayName("Talla")]//Nombre a visualizar.
        [Required(ErrorMessage = "El Talla de Producto es requerido.")]//Validaciones

        public string ProductSize
        {
            get { return _SizeP; }
            set { _SizeP = value; }
        }

        //Posición 7
        [DisplayName("Foto")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        public byte[] ProductPhoto
        {
            get { return _PhotoP; }
            set { _PhotoP = value; }

        }
        #endregion

        #region -> Métodos (Mapear datos)

        //Mapear modelo de dominio a modelo de vista
        public ProductViewModel MapProViewModel(ProductModel productModel)
        {
            var prodcViewModel = new ProductViewModel
            {
                ProductId = productModel.ProductId,
                ProductName = productModel.ProductName,
                ProductDescription = productModel.ProductDescription,
                ProductPrice = productModel.ProductPrice,
                ProductSize = productModel.ProductSize,
                ProductColor = productModel.ProductColor,
                ProductStock = productModel.ProductStock,
                ProductPhoto = productModel.ProductPhoto
            };
            return prodcViewModel;
        }
        public List<ProductViewModel> MapProductViewModel(IEnumerable<ProductModel> prodctModelList)
        {
            var productViewModelList = new List<ProductViewModel>();

            foreach (var produModel in prodctModelList)
            {
                productViewModelList.Add(MapProViewModel(produModel));
            };
            return productViewModelList;
        }



        //Mapear modelo de vista a modelo de dominio
        public ProductModel MapProducModel(ProductViewModel producViewModel)
        {
            var producModel = new ProductModel
            {
                ProductId = producViewModel.ProductId,
                ProductName = producViewModel.ProductName,
                ProductDescription = producViewModel.ProductDescription,
                ProductPrice = producViewModel.ProductPrice,
                ProductSize = producViewModel.ProductSize,
                ProductColor = producViewModel.ProductColor,
                ProductStock = producViewModel.ProductStock,
                ProductPhoto = producViewModel.ProductPhoto
            };
            return producModel;
        }
        public List<ProductModel> MapProducModel(List<ProductViewModel> producViewModelList)
        {
            var productModelList = new List<ProductModel>();

            foreach (var producViewModel in producViewModelList)
            {
                productModelList.Add(MapProducModel(producViewModel));
            };
            return productModelList;
        }
        #endregion

    }
}
