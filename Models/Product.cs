using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTaskJulianBenda.Models
{
    public class Product
    {
        public long id { get; set; }
        public long product_id { get; set; }
        public string product_name { get; set; }
        public long stock_available { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
