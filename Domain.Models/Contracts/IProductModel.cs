using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Contracts
{
    public interface IProductModel : IBaseModel<ProductModel>
    {
        int AddRange(List<ProductModel> products);
        int RemoveRange(List<ProductModel> products);

    }
}
