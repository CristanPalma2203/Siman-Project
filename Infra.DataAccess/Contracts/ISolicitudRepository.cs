using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.IO.Util.IntHashtable;

namespace Infra.DataAccess.Contracts
{
    public interface ISolicitudRepository : IGenericRepository<Solicitud>
    {
        //IEnumerable<Solicitud> GetAll();//Listar todas las entidades.
    }
}
