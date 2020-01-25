using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTaskJulianBenda.Models
{
    public class ProductRequest
    {
        public int product_id { get; set; }
        public int quantity { get; set; } = -1;
    }

    public class ProductRequestRespond
    { 
        public bool can_fulfill { get; set; }
    }
}
