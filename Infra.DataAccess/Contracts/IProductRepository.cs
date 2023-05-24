using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        int AddRange(List<Product> products);
        int RemoveRange(List<Product> products);
    }
}

