using System;
using System.Collections.Generic;

namespace WebAPI.Providers.Database.MySQL.Models
{
    public partial class Wslriskcategory
    {
        public int SlriskCategoryId { get; set; }
        public string SlriskCategoryDesc { get; set; } = null!;
    }
}
