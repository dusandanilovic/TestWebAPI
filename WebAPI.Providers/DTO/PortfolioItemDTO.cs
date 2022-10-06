using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Providers.DTO
{
    public class PortfolioItemDTO
    {
        public int Id { get; set; }
        //public DateOnly EntryDate { get; set; }

        public string ItemNo { get; set; } = null!;
        public string? ItemName { get; set; }
        public string EntityNo { get; set; } = null!;
    }
}
