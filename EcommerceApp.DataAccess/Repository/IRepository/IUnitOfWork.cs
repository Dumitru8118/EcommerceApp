﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get;  }
        ICompanyRepository Company { get;  }
        IApplicationUserRepository ApplicationUser { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
