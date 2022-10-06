using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Providers.Database.MySQL.Models;

namespace WebAPI.Providers.Database.MySQL.Interfaces
{
    public interface IPortfolioItemRepository : IGenericRepository<Portfolioitem>
    {
    }
}
