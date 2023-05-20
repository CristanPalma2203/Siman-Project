using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Entities
{
    public class Custemer
    {
        public int IdCustemer { get; set; }
        public string NameCustemer { get; set; }
        public int ArchiId { get; set; }
        public string LastNameCuste { get; set; }
        public string EmailCustemer { get; set; }
        public string AddressCustemer { get; set; }
        public string PhoneNumber { get; set; }
    }
}
