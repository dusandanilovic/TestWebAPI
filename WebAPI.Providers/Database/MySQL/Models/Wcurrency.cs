using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    public partial class Wcurrency
    {
        public int CurrencyId { get; set; }
        public string? CurrencyName { get; set; }
        public string Isoalpha3 { get; set; } = null!;
        public ulong? Major { get; set; }
    }
}
