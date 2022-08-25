﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Work_14
{
    public enum ProductCategorys
    {
        Food,
        Appliances,
        Сlothes
    }

    public class Product
    {
        public string ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string ProdImage { get; set; }
        public ProductCategorys ProductCategory { get; set; }
    }
}
