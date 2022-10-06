using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Providers.Database.MySQL.Models;

namespace WebAPI.Providers.DTO
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Portfolioitem, PortfolioItemDTO>().ReverseMap();
        }
    }
}
