using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    public partial class Wspecializedlending
    {
        public int SpecializedLendingId { get; set; }
        public string SpecializedLendingDesc { get; set; } = null!;
    }
}
