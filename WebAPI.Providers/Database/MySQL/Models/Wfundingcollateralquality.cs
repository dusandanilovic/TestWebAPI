using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    public partial class Wfundingcollateralquality
    {
        public int FundingCollateralQualityId { get; set; }
        public string FundingCollateralQualityDesc { get; set; } = null!;
    }
}
