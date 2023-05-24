using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Contracts
{
    public interface ICatalogueRepository : IGenericRepository<Catalogue>
    {
        int AddRange(List<Catalogue> catalogues);
        int RemoveRange(List<Catalogue> catalogues);
    }
}
