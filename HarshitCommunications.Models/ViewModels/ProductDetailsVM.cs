﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshitCommunications.Models.ViewModels
{
    public class ProductDetailsVM
    {
        public ShoppingCart Cart { get; set; }
        public IEnumerable<Product> RelatedProducts { get; set; }
    }
}
