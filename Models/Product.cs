﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTaskJulianBenda.Models
{
    public class Product
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int stock_available { get; set; }
        public TimeSpan created_at { get; set; }
        public TimeSpan updated_at { get; set; }
    }
}
