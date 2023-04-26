using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Common
{
    public enum TransactionAction
    {//Enumeraciones para determinar la tarea o acción de una transacción.
     //Para mas detalles ver el ejemplo del formulario UserMaintenance de la capa de interfaz de usuario.
        Add=1,
        Edit=2, 
        Remove=3,
        View = 4,
        Special=5//Puedes usar esta accion para casos especiales, en este caso se usó para editar
        //el perfil de usuario del usuario conectado, ver el formulario UserMaintenance de la capa de interfaz de usuario.
    }
}
