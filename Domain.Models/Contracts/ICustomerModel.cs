using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Contracts
{
    public interface ICustomerModel : IBaseModel<CustomerModel>
    {
        int AddRange(List<CustomerModel> customerModels);
        int RemoveRange(List<CustomerModel> customerModels);

    }
}
