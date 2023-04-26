using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Contracts
{
    public interface IBaseModel<Model> where Model : class
    {
        int Add(Model model);
        int Edit(Model model);
        int Remove(Model model);       

        Model GetSingle(string value);
        IEnumerable<Model> GetAll();
        IEnumerable<Model> GetByValue(string value);
        
    }
}
