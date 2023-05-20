using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Contracts
{
    public interface ISolicitudModel : IBaseModel<SolicitudModel>
    {
        int AddRange(List<SolicitudModel> solicitudes);
    }
}
