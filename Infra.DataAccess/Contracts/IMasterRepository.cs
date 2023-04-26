using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Contracts
{
    public interface IMasterRepository
    {//Esta interfaz define los comportamientos públicos de la clase MasterRepository.

        //Métodos para ejecutar comandos de Insertar, Actualizar y Eliminar.
        int ExecuteNonQuery(string commandText, SqlParameter parameter, CommandType commandType);
        int ExecuteNonQuery(string commandText, List<SqlParameter> parameters, CommandType commandType);
        int BulkExecuteNonQuery(List<BulkTransaction> transactions, CommandType commandType);
        
        //Métodos para ejecutar comandos de consulta (Seleccionar)
        DataTable ExecuteReader(string commandText, CommandType commandType);
        DataTable ExecuteReader(string commandText, SqlParameter parameter, CommandType commandType);
        DataTable ExecuteReader(string commandText, List<SqlParameter> parameters, CommandType commandType);  
    }
}
