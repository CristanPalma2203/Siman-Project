using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Entities
{
    public class Solicitud
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdUsuarioGestion { get; set; }
        public string UsuarioGestion { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public int EstadoId { get; set; }
        public string Indicaciones { get; set; }
        public string Observaciones { get; set; }
    }
}
