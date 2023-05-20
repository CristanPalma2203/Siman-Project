using Infra.DataAccess.Contracts;
using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositories
{
    public class ProductRepository : MasterRepository, IProductRepository
    {
        public int Add(Product entity)
        {//Ejemplo de una transacción con varios parámetros usando un procedimiento almacenado:
         //Agregar un nuevo productos.IProductRepository

            var parameters = new List<SqlParameter>();//Crear una lista para los parámetros de la transacción.
            parameters.Add(new SqlParameter("@ProductName", entity.ProductName));
            parameters.Add(new SqlParameter("@ProductDescription", entity.ProductDescription));
            parameters.Add(new SqlParameter("@ProductPrice", entity.ProductPrice));
            parameters.Add(new SqlParameter("@ProductSize", entity.ProductSize));
            parameters.Add(new SqlParameter("@ProductColor", entity.ProductColor));
            parameters.Add(new SqlParameter("@ProductStock", entity.ProductStock));
            if (entity.ProductPhoto != null)//Si la propiedad Foto es diferente a nulo, asignar el valor de la propiedad.
                parameters.Add(new SqlParameter("@ProductPicture", entity.ProductPhoto) { SqlDbType = SqlDbType.VarBinary });//En este caso del campo Foto, es importante especificar explícitamente el tipo de dato de SQL.
            else //Caso contrario asignar un valor nulo de SQL.                                              //Puedes hacer lo mismo con los otros parámetros, sin embargo es opcional,  
                parameters.Add(new SqlParameter("@ProductPicture", DBNull.Value) { SqlDbType = SqlDbType.VarBinary });//El tipo de datos será derivará del tipo de dato de su valor.

            //Ejecutar el método ExecuteNonQuery de la clase MasterRepository para realizar una transacción de insertar,
            //y enviar los parámetros necesarios (Comando de texto, parámetros y tipo de comando).
            return ExecuteNonQuery("AddProduct", parameters, CommandType.StoredProcedure);
        }
        public int Edit(Product entity)
        {
            //Ejemplo de una transacción con varios parámetros usando un procedimiento almacenado:
            //Editar Product.
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@ProductId", entity.ProductId));
            parameters.Add(new SqlParameter("@ProductName", entity.ProductName));
            parameters.Add(new SqlParameter("@ProductDescription", entity.ProductDescription));
            parameters.Add(new SqlParameter("@ProductPrice", entity.ProductPrice));
            parameters.Add(new SqlParameter("@ProductSize", entity.ProductSize));
            parameters.Add(new SqlParameter("@ProductColor", entity.ProductColor));
            parameters.Add(new SqlParameter("@ProductStock", entity.ProductStock));
            if (entity.ProductPhoto != null)
                parameters.Add(new SqlParameter("@ProductPicture", entity.ProductPhoto) { SqlDbType = SqlDbType.VarBinary });
            else parameters.Add(new SqlParameter("@ProductPicture", DBNull.Value) { SqlDbType = SqlDbType.VarBinary });

            //Ejecutar el método ExecuteNonQuery de la clase MasterRepository para realizar una transacción de actualizar,
            //y enviar los parámetros necesarios (Comando de texto, parámetros y tipo de comando).

            return ExecuteNonQuery("EditProduct", parameters, CommandType.StoredProcedure);
        }
        public int Remove(Product entity)   
        {//Ejemplo de una transacción con un solo parámetro usando un comando Transact-SQL:
         //Eliminar Product.

            string sqlCommand = "delete from Product where ProductId=@ProductId";//Comando de tipo texto (Transact-SQL)
            return ExecuteNonQuery(sqlCommand, new SqlParameter("@ProductId", entity.ProductId), CommandType.Text);
        }
        public int AddRange(List<Product> products)
        {//Ejemplo de una transacción masiva usando un procedimiento almacenado:
         //Agregar varios Product.

            var transactions = new List<BulkTransaction>();//Crear una lista genérica para las transacciones.

            foreach (var product in products)//Recorrer la lista de usuarios y agregar la instrucciones a la lista de transacciones.
            {
                var trans = new BulkTransaction();//Crear un objeto de transacción.
                var parameters = new List<SqlParameter>();//Crear una lista para los parámetros de la transacción.
                //En este caso de una transacción masiva, es conveniente especificar el tipo de dato del parámetro.
                parameters.Add(new SqlParameter("@ProductName", product.ProductName) { SqlDbType = SqlDbType.NVarChar });
                parameters.Add(new SqlParameter("@ProductDescription", product.ProductDescription) { SqlDbType = SqlDbType.NVarChar });
                parameters.Add(new SqlParameter("@ProductPrice", product.ProductPrice) { SqlDbType = SqlDbType.Decimal });
                parameters.Add(new SqlParameter("@ProductSize", product.ProductSize) { SqlDbType = SqlDbType.NVarChar });
                parameters.Add(new SqlParameter("@ProductColor", product.ProductColor) { SqlDbType = SqlDbType.NVarChar });
                parameters.Add(new SqlParameter("@ProductStock", product.ProductStock) { SqlDbType = SqlDbType.Int });
                if (product.ProductPhoto != null)
                    parameters.Add(new SqlParameter("@ProductPicture", product.ProductPhoto) { SqlDbType = SqlDbType.VarBinary });
                else parameters.Add(new SqlParameter("@ProductPicture", DBNull.Value) { SqlDbType = SqlDbType.VarBinary });

                trans.CommandText = "AddProduct";//Establecer el comando de texto(En este caso un procedimiento almacenado).
                trans.Parameters = parameters;//Establecer los parametros de la instrucción (Comando de texto).

                transactions.Add(trans);//Agregar la transacción a la lista de transacciones.
            }
            //Puede continuar agregando más transacciones a otras tablas a la lista genérica de transacciones.

            //Finalmente ejecutar todas las instrucciones de la lista de transacciones usando el método
            //BulkExecuteNonQuery de la clase base MasterRepository, enviar los parámetros necesarios
            //(Lista de transacciones y el tipo de comando.)
            return BulkExecuteNonQuery(transactions, CommandType.StoredProcedure);
        }
        public int RemoveRange(List<Product> products)
        {//Ejemplo de una transacción masiva usando un comando Transact-SQL:
         //Eliminar varios Product.

            var transactions = new List<BulkTransaction>();

            foreach (var product in products)
            {
                var trans = new BulkTransaction();
                trans.CommandText = "delete from Product where ProductId=@ProductId";
                trans.Parameters = new List<SqlParameter>{
                   new SqlParameter("@ProductId", product.ProductId){SqlDbType=SqlDbType.Int}};

                transactions.Add(trans);
            }
            return BulkExecuteNonQuery(transactions, CommandType.Text);
        }

        public Product GetSingle(string value)
        {//Ejemplo de una consulta usando un comando Transact-SQL con un parámetro:
         //Obtener un product según el valor espeficicado (Buscar).

            string sqlCommand;
            DataTable table;
            int idProduct;
            bool dato = int.TryParse(value, out idProduct);
            if (dato)
            {
                table = ExecuteReader("SelectProductId", new SqlParameter("@findValue", idProduct), CommandType.StoredProcedure);
            }
            else
            {
                table = ExecuteReader("SelectProduct", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }

            if (table.Rows.Count > 0)//Si la consulta tiene resultado
            {
                var product = new Product();//Crear un objeto Product y asignar los valores.
                foreach (DataRow row in table.Rows)
                {
                    product.ProductId = Convert.ToInt32(row[0]);
                    product.ProductName = row[1].ToString();
                    product.ProductDescription = row[2].ToString();
                    product.ProductPrice = Convert.ToDouble(row[3]);
                    product.ProductSize = row[4].ToString();
                    product.ProductColor = row[5].ToString();
                    product.ProductStock = Convert.ToInt32(row[6]);
                    if (row[7] != DBNull.Value) product.ProductPhoto = (byte[])row[7];
                }
                //Opcionalmente desechar la tabla para liberar memoria.
                table.Clear();
                table = null;

                return product;//Retornar usuario encontrado.
            }
            else//Si la consulta no fué exitosa, retornar nulo.
                return null;
        }
        public IEnumerable<Product> GetAll()
        {
            var ProductList = new List<Product>();
            var table = ExecuteReader("SelectAllProducts", CommandType.StoredProcedure);

            foreach (DataRow row in table.Rows)
            {
                var product = new Product();
                product.ProductId = Convert.ToInt32(row[0]);
                product.ProductName = row[1].ToString();
                product.ProductDescription = row[2].ToString();
                product.ProductPrice = Convert.ToDouble(row[3]);
                product.ProductSize = row[4].ToString();
                product.ProductColor = row[5].ToString();
                product.ProductStock = Convert.ToInt32(row[6]);
                if (row[7] != DBNull.Value) product.ProductPhoto = (byte[])row[7];

                ProductList.Add(product);
            }
            table.Clear();
            table = null;

            return ProductList;
        }

        public IEnumerable<Product> GetByValue(string value)
        {
            DataTable table;
            int IdProduct;
            bool dato = int.TryParse(value, out IdProduct);
            if (dato)
            {
               
                table = ExecuteReader("SelectProductId", new SqlParameter("@findValue", IdProduct), CommandType.StoredProcedure);
            }
            else {
                table = ExecuteReader("SelectProduct", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }
            ///

            var ProductList = new List<Product>();
            
            foreach (DataRow row in table.Rows)
            {
                var product = new Product();
                product.ProductId = Convert.ToInt32(row[0]);
                product.ProductName = row[1].ToString();
                product.ProductDescription = row[2].ToString();
                product.ProductPrice = Convert.ToDouble(row[3]);
                product.ProductSize = row[4].ToString();
                product.ProductColor = row[5].ToString();
                product.ProductStock = Convert.ToInt32(row[6]);
                if (row[7] != DBNull.Value) product.ProductPhoto = (byte[])row[7];

                ProductList.Add(product);
            }
            table.Clear();
            table = null;

            return ProductList;
        }



    }
}
