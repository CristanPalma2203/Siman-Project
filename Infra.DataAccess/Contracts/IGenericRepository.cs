using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Contracts
{
    public interface IGenericRepository<Entity> where Entity : class
    {//Esta interfaz define los comportamientos públicos comunes para todas las entidades.

        int Add(Entity entity);//Agregar nueva entidad.
        int Edit(Entity entity);//Editar una entidad.
        int Remove(Entity entity);//Eliminar una entidad.

        Entity GetSingle(string value);//Obtener una entidad por valor(Buscar).
        IEnumerable<Entity> GetAll();//Listar todas las entidades.
        IEnumerable<Entity> GetByValue(string value);//Listar entidades por valor(Filtrar).
    }
}
