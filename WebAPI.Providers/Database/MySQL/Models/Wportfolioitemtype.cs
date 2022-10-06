using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    public partial class Wportfolioitemtype
    {
        public int PortfolioItemTypeId { get; set; }
        public ulong? IsLiability { get; set; }
        public ulong? IsBalanceItem { get; set; }
        public ulong? IsAgregatePositionItem { get; set; }
        public string? PortfolioItemTypeDesc { get; set; }
        public int PortfolioItemTypeIdPk { get; set; }
    }
}
