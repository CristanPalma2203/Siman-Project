using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Contracts
{
    public interface IUserModel : IBaseModel<UserModel>
    {
        int AddRange(List<UserModel> users);
        int RemoveRange(List<UserModel> users);
        UserModel Login(string user, string pass);
        UserModel RecoverPassword(string requestingUser);
    }
}
