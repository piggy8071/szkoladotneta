﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }  

    }
}
