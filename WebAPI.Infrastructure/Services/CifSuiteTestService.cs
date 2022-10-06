using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Core.Services;
using WebAPI.Providers.Database.MySQL.Interfaces;
using WebAPI.Providers.Database.MySQL.Models;

namespace WebAPI.Infrastructure.Services
{
    public class CifSuiteTestService : ICifSuiteTestService
    {
        private readonly IPortfolioItemRepository repository;

        public CifSuiteTestService(IPortfolioItemRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<Portfolioitem>> GetPortfolioItems()
        {
            return await repository.GetAllAsync();
        }
    }
}
