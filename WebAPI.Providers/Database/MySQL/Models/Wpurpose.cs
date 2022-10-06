using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    public partial class Wpurpose
    {
        public int PurposeId { get; set; }
        public string PurposeDesc { get; set; } = null!;
    }
}
