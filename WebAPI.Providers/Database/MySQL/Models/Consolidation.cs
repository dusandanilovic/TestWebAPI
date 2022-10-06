using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    /// <summary>
    /// Tabela se popunjava samo u slučaju konsolidovanog izveštavan
    /// </summary>
    public partial class Consolidation
    {
        public int Id { get; set; }
        public DateOnly EntryDate { get; set; }
        public string InstitutionNo { get; set; } = null!;
        public string? InstitutionName { get; set; }
        public int? InstitutionType { get; set; }
        public int? Share { get; set; }
    }
}
