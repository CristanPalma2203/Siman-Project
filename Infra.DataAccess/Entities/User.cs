using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Entities
{
   public class User
    {//Las entidades tienen los mismos campos de la tabla de la base de datos,
        //además esto te permite  cambiar facilmente a Entity Framework.

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }

    }
}
