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
    public class ProductModel : IProductModel
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
        private IProductRepository _ProductRepository;
        #endregion

        #region -> Constructores
        public ProductModel()
        {
            _ProductRepository = new ProductRepository();
        }

        public ProductModel(int productId, string productName, string productDescription, double productPrice, string productSize, string productColor, int productStock, byte[] productPhoto)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductSize = productSize;
            ProductColor = productColor;
            ProductStock = productStock;
            ProductPhoto = productPhoto;

            _ProductRepository = new ProductRepository();
        }

        #endregion

        #region -> Propiedades

        public int ProductId
        {
            get { return _idPr; }
            set { _idPr = value; }
        }

        public String ProductName
        {
            get { return _nameP; }
            set { _nameP = value; }
        }
        public String ProductDescription
        {
            get { return _descriptionP; }
            set { _descriptionP = value; }
        }
        public double ProductPrice
        {
            get { return _priceP; }
            set { _priceP = value; }
        }

        public string ProductSize
        {
            get { return _SizeP; }
            set { _SizeP = value; }
        }

        public string ProductColor
        {
            get { return _ColorP; }
            set { _ColorP = value; }
        }
        public int ProductStock
        {
            get { return _StockP; }
            set { _StockP = value; }
        }

        public byte[] ProductPhoto
        {
            get { return _PhotoP; }
            set { _PhotoP = value; }
        }
        #endregion


        #region -> Metodos

        public int Add(ProductModel producModel)
        {
            var productEntity = MapProductEntity(producModel);
            return _ProductRepository.Add(productEntity);
        }
        public int Edit(ProductModel producModel)
        {
            var productEntity = MapProductEntity(producModel);
            return _ProductRepository.Edit(productEntity);
        }
        public int Remove(ProductModel producModel)
        {
            var productEntity = MapProductEntity(producModel);
            return _ProductRepository.Remove(productEntity);
        }
        public int AddRange(List<ProductModel> producModel)
        {
            var producEntityList = MapProductEntity(producModel);
            return _ProductRepository.AddRange(producEntityList);
        }
        public int RemoveRange(List<ProductModel> producModel)
        {
            var ProductEntityList = MapProductEntity(producModel);
            return _ProductRepository.RemoveRange(ProductEntityList);
        }

        public ProductModel GetSingle(string value)
        {
            var productEntity = _ProductRepository.GetSingle(value);
            if (productEntity != null)
                return MapProductEntity(productEntity);
            else return null;
        }
        public IEnumerable<ProductModel> GetAll()
        {
            var producEntityList = _ProductRepository.GetAll();
            return MapProductEntity(producEntityList);
        }
        public IEnumerable<ProductModel> GetByValue(string value)
        {
            var producEntityList = _ProductRepository.GetByValue(value);
            return MapProductEntity(producEntityList);
        }

        #endregion

        #region -> Métodos Privados (Mapear datos)

        //Mapear modelo entidad a modelo de dominio.
        private ProductModel MapProductEntity(Product producEntity)
        {//Mapear un solo objeto.
            var productModel = new ProductModel
            {
                ProductId = producEntity.ProductId,
                ProductName = producEntity.ProductName,
                ProductDescription = producEntity.ProductDescription,
                ProductPrice = producEntity.ProductPrice,
                ProductSize = producEntity.ProductSize,
                ProductColor = producEntity.ProductColor,
                ProductStock = producEntity.ProductStock,
                ProductPhoto = producEntity.ProductPhoto
            };
            return productModel;

        }
        private List<ProductModel> MapProductEntity(IEnumerable<Product> ProductEntityList)
        {//Mapear colección de objetos.
            var ProductModelList = new List<ProductModel>();

            foreach (var productEnty in ProductEntityList)
            {
                ProductModelList.Add(MapProductEntity(productEnty));
            };
            return ProductModelList;
        }
        //Mapear modelo de dominio a modelo de entidad.
        private Product MapProductEntity(ProductModel producEntity)
        {//Mapear un solo objeto.
            var product = new Product
            {
                ProductId = producEntity.ProductId,
                ProductName = producEntity.ProductName,
                ProductDescription = producEntity.ProductDescription,
                ProductPrice = producEntity.ProductPrice,
                ProductSize = producEntity.ProductSize,
                ProductColor = producEntity.ProductColor,
                ProductStock = producEntity.ProductStock,
                ProductPhoto = producEntity.ProductPhoto
            };
            return product;
        }
        private List<Product> MapProductEntity(List<ProductModel> producEntityList)
        {//Mapear una colección de Product.
            var producEntityLis = new List<Product>();

            foreach (var productModel in producEntityList)
            {
                producEntityLis.Add(MapProductEntity(productModel));
            };
            return producEntityLis;
        }


        #endregion

    }
}
