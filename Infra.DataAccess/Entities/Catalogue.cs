using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Entities
{
    public class Catalogue
    {
        public int CatalogueID { get; set; }
        public string CatalogueName { get; set; }
        public string Cataloguetype { get; set; }
        public string CatalogueAbbreviation { get; set; }
        public int CatalogueFatherID { get; set; }
        public DateTime CatalogueCreationDate { get; set; }
        public int CatalogueCreationUser { get; set; }
        public DateTime CatalogueUpdateDate { get; set; }
        public int CatalogueUpdateUser { get; set; }
    }
}
