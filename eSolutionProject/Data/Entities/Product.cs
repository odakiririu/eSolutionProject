using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OrginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreateDate { get; set; }
        public string SeoAlias { get; set; }


    }
}
