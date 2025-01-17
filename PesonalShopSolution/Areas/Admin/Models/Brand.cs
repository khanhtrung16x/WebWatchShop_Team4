﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PesonalShopSolution.Areas.Admin.Models
{
    public partial class Brand
    {

        public int IdBrand { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
