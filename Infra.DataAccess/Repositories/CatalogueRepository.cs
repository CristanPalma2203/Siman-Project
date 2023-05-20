using Infra.DataAccess.Contracts;
using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Infra.DataAccess.Repositories
{
    public class CatalogueRepository : MasterRepository, ICatalogueRepository
    {
        public int Add(Catalogue entity) {
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@NameCa", entity.CatalogueName));
            parameters.Add(new SqlParameter("@TypeCa",entity.Cataloguetype));
            parameters.Add(new SqlParameter("@Abreviatura", entity.CatalogueAbbreviation));
            parameters.Add(new SqlParameter("@IdFather", entity.CatalogueFatherID));
            parameters.Add(new SqlParameter("@CreationTime", entity.CatalogueCreationDate));
            parameters.Add(new SqlParameter("@CreationUser", entity.CatalogueCreationUser));
            parameters.Add(new SqlParameter("@Updatetime", entity.CatalogueUpdateDate));
            parameters.Add(new SqlParameter("@UpdateUser", entity.CatalogueUpdateUser));

            return ExecuteNonQuery("AddCatalogue", parameters, CommandType.StoredProcedure);
        }

        public int Edit(Catalogue entity) {
            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IdCate", entity.CatalogueID));
            parameters.Add(new SqlParameter("@NameCa", entity.CatalogueName));
            parameters.Add(new SqlParameter("@TypeCa", entity.Cataloguetype));
            parameters.Add(new SqlParameter("@Abreviatura", entity.CatalogueAbbreviation));
            parameters.Add(new SqlParameter("@IdFather", entity.CatalogueFatherID));
            parameters.Add(new SqlParameter("@CreationTime", entity.CatalogueCreationDate));
            parameters.Add(new SqlParameter("@CreationUser", entity.CatalogueCreationUser));
            parameters.Add(new SqlParameter("@Updatetime", entity.CatalogueUpdateDate));
            parameters.Add(new SqlParameter("@UpdateUser", entity.CatalogueUpdateUser));

            return ExecuteNonQuery("EditCatalogue", parameters, CommandType.StoredProcedure);
        }

        public int Remove(Catalogue entity) {
            string sqlCommand= "delect from Catalogo where CatalogueID=@IdCate";//Comando de tipo texto (Transact-SQL)
            return ExecuteNonQuery(sqlCommand, new SqlParameter("@IdCate", entity.CatalogueID), CommandType.Text);
        }

        public int AddRange(List<Catalogue> catalogues) {

            var transactions = new List<BulkTransaction>();//Crear una lista genérica para las transacciones.
       
            foreach (var catalogue in catalogues)//Recorrer la lista de usuarios y agregar la instrucciones a la lista de transacciones.
            {
                var trans = new BulkTransaction();//Crear un objeto de transacción.
                var parameters = new List<SqlParameter>();//Crear una lista para los parámetros de la transacción.

                parameters.Add(new SqlParameter("@NameCa", catalogue.CatalogueName) { SqlDbType = SqlDbType.NVarChar });
                parameters.Add(new SqlParameter("@TypeCa", catalogue.Cataloguetype) { SqlDbType = SqlDbType.NVarChar });
                parameters.Add(new SqlParameter("@Abreviatura", catalogue.CatalogueAbbreviation) { SqlDbType = SqlDbType.NVarChar });
                parameters.Add(new SqlParameter("@IdFather", catalogue.CatalogueFatherID) { SqlDbType = SqlDbType.Int });
                parameters.Add(new SqlParameter("@CreationTime", catalogue.CatalogueCreationDate) { SqlDbType = SqlDbType.DateTime});
                parameters.Add(new SqlParameter("@CreationUser", catalogue.CatalogueCreationUser) { SqlDbType = SqlDbType.Int });
                parameters.Add(new SqlParameter("@UpdateDate", catalogue.CatalogueUpdateDate) { SqlDbType = SqlDbType.DateTime });
                parameters.Add(new SqlParameter("@UpdateUser", catalogue.CatalogueUpdateUser) { SqlDbType = SqlDbType.Int });

                trans.CommandText = "AddCatalogue";//Establecer el comando de texto(En este caso un procedimiento almacenado).
                trans.Parameters = parameters;//Establecer los parametros de la instrucción (Comando de texto).

                transactions.Add(trans);
            }

            return BulkExecuteNonQuery(transactions, CommandType.StoredProcedure);

        }

        public int RemoveRange(List<Catalogue> catalogues) {
            var transactions = new List<BulkTransaction>();

            foreach (var catalogue in catalogues)
            {
                var trans = new BulkTransaction();
                trans.CommandText = "delete from Catalogo where CatalogueID=@IdCate";
                trans.Parameters = new List<SqlParameter>{
                   new SqlParameter("@IdCate", catalogue.CatalogueID){SqlDbType=SqlDbType.Int}};

                transactions.Add(trans);
            }
            return BulkExecuteNonQuery(transactions, CommandType.Text);
        }

        public Catalogue GetSingle(string value) {
            string sqlCommand;
            DataTable table;
            int idCatalogue;

            bool dato = int.TryParse(value, out idCatalogue);
            if (dato)
            {
                table = ExecuteReader("SelectCatalogueId", new SqlParameter("@findValue", idCatalogue), CommandType.StoredProcedure);
            }
            else
            {
                table = ExecuteReader("SelectCatalgoue", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }

            if (table.Rows.Count > 0)//Si la consulta tiene resultado
            {
                var catalogue = new Catalogue();//Crear un objeto Product y asignar los valores.
                foreach (DataRow row in table.Rows)
                {
                    catalogue.CatalogueID = Convert.ToInt32(row[0]);
                    catalogue.CatalogueName = row[1].ToString();
                    catalogue.Cataloguetype = row[2].ToString();
                    catalogue.CatalogueAbbreviation = row[3].ToString();
                    catalogue.CatalogueFatherID = Convert.ToInt32(row[4]);
                    catalogue.CatalogueCreationDate = Convert.ToDateTime(row[5]);
                    catalogue.CatalogueCreationUser = Convert.ToInt32(row[6]);
                    catalogue.CatalogueUpdateDate = Convert.ToDateTime(row[7]);
                    catalogue.CatalogueUpdateUser = Convert.ToInt32(row[6]);

                }
                //Opcionalmente desechar la tabla para liberar memoria.
                table.Clear();
                table = null;

                return catalogue;//Retornar usuario encontrado.
            }
            else//Si la consulta no fué exitosa, retornar nulo.
                return null;
        }

        public IEnumerable<Catalogue> GetAll() {
            var catalogueList = new List<Catalogue>();
            var table = ExecuteReader("SelectAllCatalogue", CommandType.StoredProcedure);


            foreach (DataRow row in table.Rows)
            {
                var catalogue = new Catalogue();
                catalogue.CatalogueID = Convert.ToInt32(row[0]);
                catalogue.CatalogueName = row[1].ToString();
                catalogue.Cataloguetype = row[2].ToString();
                catalogue.CatalogueAbbreviation = row[3].ToString();
                catalogue.CatalogueFatherID = Convert.ToInt32(row[4]);
                catalogue.CatalogueCreationDate = Convert.ToDateTime(row[5]);
                catalogue.CatalogueCreationUser = Convert.ToInt32(row[6]);
                catalogue.CatalogueUpdateDate = Convert.ToDateTime(row[7]);
                catalogue.CatalogueUpdateUser = Convert.ToInt32(row[8]);

                catalogueList.Add(catalogue);
            }
            table.Clear();
            table = null;

            return catalogueList;

        }

        public IEnumerable<Catalogue> GetByValue(string value)
        {
            DataTable table;
            int IdCatalogue;
            bool dato = int.TryParse(value, out IdCatalogue);
            if (dato)
            {

                table = ExecuteReader("SelectCataloguetId", new SqlParameter("@findValue", IdCatalogue), CommandType.StoredProcedure);
            }
            else
            {
                table = ExecuteReader("SelectCatalgoue", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }
            ///

            var CatalogueList = new List<Catalogue>();

            foreach (DataRow row in table.Rows)
            {
                var catalogue = new Catalogue();
                catalogue.CatalogueID = Convert.ToInt32(row[0]);
                catalogue.CatalogueName = row[1].ToString();
                catalogue.Cataloguetype = row[2].ToString();
                catalogue.CatalogueAbbreviation = row[3].ToString();
                catalogue.CatalogueFatherID = Convert.ToInt32(row[4]);
                catalogue.CatalogueCreationDate = Convert.ToDateTime(row[5]);
                catalogue.CatalogueCreationUser = Convert.ToInt32(row[6]);
                catalogue.CatalogueUpdateDate = Convert.ToDateTime(row[7]);
                catalogue.CatalogueUpdateUser = Convert.ToInt32(row[6]);

                CatalogueList.Add(catalogue);
            }
            table.Clear();
            table = null;

            return CatalogueList;
        }

    }
}
