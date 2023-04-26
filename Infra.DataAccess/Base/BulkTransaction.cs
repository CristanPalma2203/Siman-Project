using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess
{
    public class BulkTransaction
    {
        /// <summary>
        /// Esta clase simplemente es responsable de almacenar un comando de texto y una lista de parámetros
        /// para el comando de texto (Transact-SQL o Procedimiento almacenado) para realizar transacciones masivas.
        /// Para mas detalles ver el método BulkExecuteNonQuery() de la clase MasterRepository.
        /// </summary>
        /// 
        public string CommandText { get; set; }//Obtiene o establece un comando de texto.
        public List<SqlParameter> Parameters { get; set; } //Obtiene o establece una colección de parámetros para el comando de texto.

        public BulkTransaction()
        {
            Parameters = new List<SqlParameter>();//Inicializar la lista de parámetros.
        }
    }
}
