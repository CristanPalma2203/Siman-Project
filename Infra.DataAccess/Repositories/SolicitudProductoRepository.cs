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
    public class SolicitudProductoRepository : MasterRepository, ISolicitudProductoRepository
    {
        public int Add(SolicitudProducto entity)
        {
            throw new NotImplementedException();
        }

        public int Edit(SolicitudProducto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SolicitudProducto> GetAll()
        {
            var solicitudProductoList = new List<SolicitudProducto>();
            var table = ExecuteReader("select * from SolicitudProducto", CommandType.Text);

            foreach (DataRow row in table.Rows)
            {
                var solicitudProducto = new SolicitudProducto();

                solicitudProducto.Id = Convert.ToInt32(row[0]);
                solicitudProducto.IdSolicitud = Convert.ToInt32(row[1]);
                solicitudProducto.IdProducto = Convert.ToInt32(row[2]);
                solicitudProducto.Cantidad = Convert.ToInt32(row[3]);
                solicitudProducto.SubTotal = Convert.ToDecimal(row[4]);

                solicitudProductoList.Add(solicitudProducto);
            }

            table.Clear();
            table = null;

            return solicitudProductoList;
        }

        //Buscar
        public IEnumerable<SolicitudProducto> GetByValue(string value)
        {
            //string sqlCommand;
            DataTable table;
            int id;

            var solicitudProductoList = new List<SolicitudProducto>();
            bool isNumeric = int.TryParse(value, out id);//Determinar si el parámetro valor es un numero entero.

            if (isNumeric)//Si el valor es un número, realizar la consulta usando el id del usuario.
            {
                table = ExecuteReader(
                    "select * from SolicitudProducto where id = @findValue", new SqlParameter("@findValue", id), CommandType.Text);
            }
            else //Caso contrario, realizar la consulta usando el nombre de cliente o usuario gestion.
            {
                table = ExecuteReader("select * from SolicitudProducto", CommandType.Text);
            }

            foreach (DataRow row in table.Rows)
            {
                var solicitudProducto = new SolicitudProducto();

                solicitudProducto.Id = Convert.ToInt32(row[0]);
                solicitudProducto.IdSolicitud = Convert.ToInt32(row[1]);
                solicitudProducto.IdProducto = Convert.ToInt32(row[2]);
                solicitudProducto.Cantidad = Convert.ToInt32(row[3]);
                solicitudProducto.SubTotal = Convert.ToDecimal(row[4]);

                solicitudProductoList.Add(solicitudProducto);
            }
            table.Clear();
            table = null;

            return solicitudProductoList;
        }

        //Este metodo es para los Detalles
        public SolicitudProducto GetSingle(string value)
        {

            //string sqlCommand;
            DataTable table;
            int id;

            bool isNumeric = int.TryParse(value, out id);//Determinar si el parámetro valor es un numero entero.
            if (isNumeric)//Si el valor es un número, realizar la consulta usando el id del usuario.
            {
                table = ExecuteReader(
                    "select * from SolicitudProducto where id = @findValue", new SqlParameter("@findValue", id), CommandType.Text);
            }
            else //Caso contrario, realizar la consulta usando el nombre de cliente o usuario gestion.
            {
                //table = ExecuteReader("SelectSolicitud", new SqlParameter("@findValue", value), CommandType.StoredProcedure);
                return null;
            }

            if (table.Rows.Count > 0)//Si la consulta tiene resultado
            {
                var solicitudProducto = new SolicitudProducto();//Crear un objeto solicitud y asignar los valores.

                foreach (DataRow row in table.Rows)
                {
                    solicitudProducto.Id = Convert.ToInt32(row[0]);
                    solicitudProducto.IdSolicitud = Convert.ToInt32(row[1]);
                    solicitudProducto.IdProducto = Convert.ToInt32(row[2]);
                    solicitudProducto.Cantidad = Convert.ToInt32(row[3]);
                    solicitudProducto.SubTotal = Convert.ToDecimal(row[4]);
                }
                //Opcionalmente desechar la tabla para liberar memoria.
                table.Clear();
                table = null;

                return solicitudProducto;//Retorna la solicitud encontrada
            }
            else return null;
        }

        public int Remove(SolicitudProducto entity)
        {
            throw new NotImplementedException();
        }
    }
}
