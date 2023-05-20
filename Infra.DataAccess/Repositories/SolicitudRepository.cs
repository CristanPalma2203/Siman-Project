using Infra.DataAccess.Contracts;
using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositories
{
    public class SolicitudRepository : MasterRepository, ISolicitudRepository
    {
        public int Add(Solicitud entity)
        {//Ejemplo de una transacción con varios parámetros usando un procedimiento almacenado:
         //Agregar un nuevo usuario.

            var parameters = new List<SqlParameter>();//Crear una lista para los parámetros de la transacción.
            parameters.Add(new SqlParameter("@idCliente", Convert.ToInt32(entity.IdCliente)));
            parameters.Add(new SqlParameter("@idUsuarioGestion", Convert.ToInt32(entity.IdUsuarioGestion)));
            parameters.Add(new SqlParameter("@fechaVenta", entity.FechaVenta));
            parameters.Add(new SqlParameter("@totalVenta", entity.TotalVenta));
            
            //Ejecutar el método ExecuteNonQuery de la clase MasterRepository para realizar una transacción de insertar,
            //y enviar los parámetros necesarios (Comando de texto, parámetros y tipo de comando).
            return ExecuteNonQuery("AddSolicitud", parameters, CommandType.StoredProcedure);
        }

        public int Edit(Solicitud entity)
        {//Ejemplo de una transacción con varios parámetros usando un procedimiento almacenado:
         //Editar Solicitud.

            var parameters = new List<SqlParameter>();//Crear una lista para los parámetros de la transacción.
            parameters.Add(new SqlParameter("@id", entity.Id));
            parameters.Add(new SqlParameter("@estadoId", entity.EstadoId));
            parameters.Add(new SqlParameter("@indicaciones", entity.Indicaciones));
            parameters.Add(new SqlParameter("@observaciones", entity.Observaciones));

            //Ejecutar el método ExecuteNonQuery de la clase MasterRepository para realizar una transacción de actualizar,
            //y enviar los parámetros necesarios (Comando de texto, parámetros y tipo de comando).
            return ExecuteNonQuery("EditSolicitud", parameters, CommandType.StoredProcedure);
        }

        public IEnumerable<Solicitud> GetAll()
        {
            var solicitudList = new List<Solicitud>();
            var table = ExecuteReader("SelectAllSolicitud", CommandType.StoredProcedure);

            foreach (DataRow row in table.Rows)
            {
                var solicitud = new Solicitud();

                solicitud.Id = Convert.ToInt32(row[0]);
                solicitud.NombreCliente = row[1].ToString();
                solicitud.UsuarioGestion = row[2].ToString();
                solicitud.FechaVenta = Convert.ToDateTime(row[3]);
                solicitud.TotalVenta = Convert.ToDecimal(row[4]);
                solicitud.EstadoId = Convert.ToInt32(row[5]);
                solicitud.Indicaciones = row[6].ToString();
                solicitud.Observaciones = row[7].ToString();

                solicitudList.Add(solicitud);
            }

            table.Clear();
            table = null;

            return solicitudList;
        }

        //Buscar
        public IEnumerable<Solicitud> GetByValue(string value)
        {
            //string sqlCommand;
            DataTable table;
            int idSolicitud;

            var solicitudList = new List<Solicitud>();
            bool isNumeric = int.TryParse(value, out idSolicitud);//Determinar si el parámetro valor es un numero entero.

            if (isNumeric)//Si el valor es un número, realizar la consulta usando el id del usuario.
            {
                table = ExecuteReader("SelectSolicitudId", new SqlParameter("@findValue", idSolicitud), CommandType.StoredProcedure);
            }
            else //Caso contrario, realizar la consulta usando el nombre de cliente o usuario gestion.
            {
                table = ExecuteReader("SelectSolicitud", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }
                        
            foreach (DataRow row in table.Rows)
            {
                var solicitud = new Solicitud();

                solicitud.Id = Convert.ToInt32(row[0]);
                solicitud.NombreCliente = row[1].ToString();
                solicitud.UsuarioGestion = row[2].ToString();
                solicitud.FechaVenta = Convert.ToDateTime(row[3]);
                solicitud.TotalVenta = Convert.ToDecimal(row[4]);
                solicitud.EstadoId = Convert.ToInt32(row[5]);
                solicitud.Indicaciones = row[6].ToString();
                solicitud.Observaciones = row[7].ToString();

                solicitudList.Add(solicitud);
            }
            table.Clear();
            table = null;

            return solicitudList;
        }

        //Este metodo es para los Detalles
        public Solicitud GetSingle(string value)
        {

            //string sqlCommand;
            DataTable table;
            int idSolicitud;

            bool isNumeric = int.TryParse(value, out idSolicitud);//Determinar si el parámetro valor es un numero entero.
            if(isNumeric)//Si el valor es un número, realizar la consulta usando el id del usuario.
            {
                table = ExecuteReader("SelectSolicitudId", new SqlParameter("@findValue", idSolicitud), CommandType.StoredProcedure);
            }
            else //Caso contrario, realizar la consulta usando el nombre de cliente o usuario gestion.
            {
                table = ExecuteReader("SelectSolicitud", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
            }

            if (table.Rows.Count > 0)//Si la consulta tiene resultado
            {
                var solicitud = new Solicitud();//Crear un objeto solicitud y asignar los valores.

                foreach (DataRow row in table.Rows)
                {
                    solicitud.Id = Convert.ToInt32(row[0]);
                    solicitud.NombreCliente = row[1].ToString();
                    solicitud.UsuarioGestion = row[2].ToString();
                    solicitud.FechaVenta = Convert.ToDateTime(row[3]);
                    solicitud.TotalVenta = Convert.ToDecimal(row[4]);
                    solicitud.EstadoId = Convert.ToInt32(row[5]);
                    solicitud.Indicaciones = row[6].ToString();
                    solicitud.Observaciones = row[7].ToString();
                }
                //Opcionalmente desechar la tabla para liberar memoria.
                table.Clear();
                table = null;

                return solicitud;//Retorna la solicitud encontrada
            }
            else return null;
        }

        public int Remove(Solicitud entity)
        {
            throw new NotImplementedException();
        }
    }
}
