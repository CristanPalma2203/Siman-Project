using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Contracts
{
    public interface ICustemerRepository : IGenericRepository<Custemer>
    {
        int AddRange(List<Custemer> custemers);
        int RemoveRange(List<Custemer> custemers);
    }

}
