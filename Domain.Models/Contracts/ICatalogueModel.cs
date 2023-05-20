﻿using Infra.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Contracts
{
    public interface ICatalogueModel : IBaseModel<CatalogueModel>
    {
        int AddRange(List<CatalogueModel> catalogues);
        int RemoveRange(List<CatalogueModel> catalogues);

    }

}
