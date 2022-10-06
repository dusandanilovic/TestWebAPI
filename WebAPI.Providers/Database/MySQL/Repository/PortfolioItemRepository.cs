using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Providers.Database.MySQL.Interfaces;
using WebAPI.Providers.Database.MySQL.Models;

namespace WebAPI.Providers.Database.MySQL.Repository
{
    public class PortfolioItemRepository : GenericRepository<Portfolioitem>, IPortfolioItemRepository
    {
        private readonly CifSuiteContext context;

        public PortfolioItemRepository(CifSuiteContext context) : base(context)
        {
            this.context = context;
        }
    }
}
