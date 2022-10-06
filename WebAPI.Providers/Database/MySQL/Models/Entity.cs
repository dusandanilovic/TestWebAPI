using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    /// <summary>
    /// Lista svih entiteta sa kojima Banka ima poslovanje.
    /// Za svaki
    /// </summary>
    public partial class Entity
    {
        public int Id { get; set; }
        public string? EntityNo { get; set; }
        public string? InternalNo { get; set; }
        public string? Name { get; set; }
        public int EntityType { get; set; }
        public string? LegalEntity { get; set; }
        public string Country { get; set; } = null!;
        public int? Sector { get; set; }
        public int? Sskrsector { get; set; }
        public int? RegionId { get; set; }
        public ulong? NonResident { get; set; }
        public ulong? Relationship { get; set; }
        public int? Treatment { get; set; }
        public ulong? IsHighNetWorthIndividual { get; set; }
        public ulong? IsUnlikelyToWithdrawFunds { get; set; }
        public int IsValidated { get; set; }
    }
}
