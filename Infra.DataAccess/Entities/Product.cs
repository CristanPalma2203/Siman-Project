using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public String ProductSize { get; set; }
        public String ProductColor { get; set; }
        public int ProductStock { get; set; }
        public byte[] ProductPhoto { get; set; }
    }
}
