using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Providers.Database.MySQL.Models;
using WebAPI.Providers.DTO;

namespace WebAPI.Core.Services
{
    public interface ICifSuiteTestService
    {
        public Task<List<Portfolioitem>> GetPortfolioItems();
    }
}
