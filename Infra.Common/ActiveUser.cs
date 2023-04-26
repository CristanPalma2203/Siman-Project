using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Common
{
    public struct ActiveUser
    {
        /// <summary>
        /// Responsable de almacenar el ID y Cargo del usuario que inició sesión, 
        /// que te permite realizar los permisos de usuario en cualquier capa.
        /// Esto es opcional , generalmente no es necesario realizar permisos
        /// de usuario en la capa de acceso a datos y dominio.
        /// </summary>
        /// 
        public static int Id {get;set;}
        public static string Position {get;set;}  
        //Esto es un ejemplo simple y básico, hay muchas maneras de hacerlo.
    }
}
