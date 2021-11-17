using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SearchApi.Models
{
    public class Result
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public Nullable<int> quantity_in_stock { get; set; }
        public Nullable<int> min_quantity_to_order { get; set; }
        public string Slab_range { get; set; }
        public Nullable<double> Slab_range_price_per_unit { get; set; }


    }
}

