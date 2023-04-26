using Infra.DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess
{
    public abstract class MasterRepository : Repository, IMasterRepository
    {
        /// <summary>
        /// Esta clase abstracta  hereda de la clase Repository e implementa la interfaz IMasterRepository.
        /// Esta clase es una clase base para todos los repositorios de entidad y es reponsable de realizar
        /// cualquier consulta y transaccion a la base de datos SQL Server, para ello implementa 3 métodos: 
        /// 
        /// -Método ExecuteNonQuery(...)-> Ejecuta comandos de transacción (Create, Update y Delete).
        /// -Método BulkExecuteNonQuery(...)-> Ejecuta comandos de transacción (Create, Update y Delete) para
        /// realizar transacciones masivas afectando a multiples filas.
        /// -Método ExecuteReader(...)-> Ejecuta comandos de consulta (Select).
        /// 
        /// Estos métodos tienen 2 o mas sobrecargas ( Es considerado como el pilar de polimorfismo de 
        /// la programación orientada a objetos.)
        /// </summary>

        private DataTable dataTable;//Obtiene o establece la tabla de datos para las consultas.     

        public MasterRepository()
        {

        }

        public int ExecuteNonQuery(string commandText, SqlParameter parameter, CommandType commandType)
        {/*Este método es responsable de ejecutar un comando de transacción (Create, Update y Delete)
          con UN SOLO PARÁMETRO, ya sea un comando Transact-SQL o procedimiento almacenado para ello
          especifique el tipo de comando al momento de invocar el método.
          Podría utilizar este método para eliminar un fila donde generalmente solo es necesario un parámetro (@id)*/

            using (var connection = GetConnection())//Obtener la conexión.
            {
                connection.Open();//Abrir la conexión.
                using (var command = new SqlCommand())//Crear objeto SqlCommand.
                {
                    command.Connection = connection;//Establecer la conexión.
                    command.CommandText = commandText;//Estabelcer el comando de texto.
                    command.CommandType = commandType;//Establecer el tipo de comando (Transact-SQL o procedimiento almacenado).
                    command.Parameters.Add(parameter);//Agregar el parámetro.
                    return command.ExecuteNonQuery(); //Ejecutar el comando de texto y retornar el numero de filas afectadas.                   
                }
            }
            /* Nota: La declaración USING garantiza que los objetos que implementan IDisposable
             * se eliminen correctamente, por lo tanto, el objeto SQLConexion y SqlCommnad se 
             * desecharán automaticamente una vez cumplan su cometido, además no es necesario 
             * cerrar la conexion y limpiar los parámetros de SqlCommand explicitamente.*/
        }
        public int ExecuteNonQuery(string commandText, List<SqlParameter> parameters, CommandType commandType)
        {/*Este método es responsable de ejecutar un comando de transacción (Create, Update y Delete)
          con VARIOS PARÁMETROS, ya sea un comando Transact-SQL o procedimiento almacenado para ello
          especifique el tipo de comando al momento de invocar el método.*/

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters.ToArray());//Agregar la colección de parámetros.
                    return command.ExecuteNonQuery();//Ejecutar el comando de texto y retornar el numero de filas afectadas.
                }
            }
        }
        public int BulkExecuteNonQuery(List<BulkTransaction> transactions, CommandType commandType)
        {/*Este método es responsable de ejecutar VARIOS COMANDOS de transacción (Create, Update y Delete)
           con VARIOS PARÁMETROS, ya sea un comando Transact-SQL o procedimiento almacenado. Es muy importante
           el uso de SqlTransaction, garantiza que todos los datos se almacenen correctamente, en caso que ocurra
           algún error, se encargará de revertir todos los cambios.
           Utilice este método si desea insertar, editar o eliminar datos masivamente (Múltiples filas y tablas)*/

            int result = 0;

            using (var connection = GetConnection())//Obtener la conexión.
            {
                connection.Open();//Abrir la conexión.

                using (SqlTransaction sqlTransaction = connection.BeginTransaction())//Inicializar la transacción.
                using (var command = new SqlCommand())//Inicializar un objeto SqlCommand.
                {
                    command.Connection = connection;
                    command.Transaction = sqlTransaction;//Establecer la transación
                    command.CommandType = commandType;
                    try
                    {
                        foreach (var trans in transactions)//Recorrer la colección de transacciones y obtener los comandos de texto con sus respectivos parámentros.
                        {
                            command.CommandText = trans.CommandText;//Establecer el comando de texto.
                            command.Parameters.AddRange(trans.Parameters.ToArray());//Agregar la colección de parámetros.
                            result += command.ExecuteNonQuery();//Ejecutar el comando de texto y acumular el numero de filas afectadas en cada ciclo.
                            command.Parameters.Clear();//Limpiar los parámetros del comando SQL.
                        }
                        sqlTransaction.Commit();//Una vez ejecutado todos los comandos, confirmar (guardar) la transacción.
                    }
                    catch (Exception)
                    {
                        //En caso de que ocurra una excepción, anular la transacción para revertir los cambios.
                        sqlTransaction.Rollback();                        
                        throw;                         
                    }
                }
            }
            return result;
        }

        public DataTable ExecuteReader(string commandText, CommandType commandType)
        {/* Este método se encarga de ejecutar comandos de consulta sin parámetros,
          * ya sea un comando Transact-SQL o procedimiento almacenado*/

            dataTable = new DataTable();//Inicializar la tabla de datos.

            using (var connection = GetConnection())//Obtener la conexión.
            {
                connection.Open();
                using (var command = new SqlCommand())//Crear el objeto SQL Command.
                {
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = commandType;

                    using (var reader = command.ExecuteReader())//Ejecutar el comando en modo lector.
                        dataTable.Load(reader);//Llenar la tabla de datos con el resultado almacenado en el lector de datos.
                }
            }
            return dataTable;//Retornar la tabla de datos
        }
        public DataTable ExecuteReader(string commandText, SqlParameter parameter, CommandType commandType)
        {/* Este método se encarga de ejecutar comandos de consulta con un parámetro,
          * ya sea un comando Transact-SQL o procedimiento almacenado*/

            dataTable = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = commandType;
                    command.Parameters.Add(parameter);

                    using (var reader = command.ExecuteReader())
                        dataTable.Load(reader);
                }
            }
            return dataTable;
        }
        public DataTable ExecuteReader(string commandText, List<SqlParameter> parameters, CommandType commandType)
        {/* Este método se encarga de ejecutar comandos de consulta con varios parámetros,
          * ya sea un comando Transact-SQL o procedimiento almacenado*/

            dataTable = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = commandType;
                    command.Parameters.AddRange(parameters.ToArray());

                    using (var reader = command.ExecuteReader())
                        dataTable.Load(reader);
                }
            }
            return dataTable;
        }
    }
}
