using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Base
{
    public class MyRepository : Repository
    {
        public MyRepository() : base()
        {
            // Aquí podrías agregar código adicional al constructor, si lo necesitas.
        }

        public List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();

            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();

                DataTable schema = conexion.GetSchema("Tables");
                foreach (DataRow row in schema.Rows)
                {
                    string tableName = (string)row[2];
                    tableNames.Add(tableName);
                }
            }

            return tableNames;
        }
    }
}
