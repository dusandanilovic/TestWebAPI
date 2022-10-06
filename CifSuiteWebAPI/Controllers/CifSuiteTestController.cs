using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.Services;
using WebAPI.Providers.DTO;

namespace CifSuiteWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CifSuiteTestController : ControllerBase
    {
        protected readonly ICifSuiteTestService cifSuiteService;

        protected readonly IMapper mapper;

        public CifSuiteTestController(ICifSuiteTestService cifSuiteService, IMapper mapper)
        {
            this.cifSuiteService = cifSuiteService;
            this.mapper = mapper;
        }

        [HttpGet("portfolioItems")]

        public async Task<IActionResult> GetPortfolioItems()
        {
            var items = mapper.Map<List<PortfolioItemDTO>>(await this.cifSuiteService.GetPortfolioItems());
            return Ok(items);
        }
    }
}