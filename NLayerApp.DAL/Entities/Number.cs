using System.Collections.Generic;
using System;

namespace NLayerApp.DAL.Entities
{
    public class Number
    {
        public int NumberId { get; set; }
        //public string Name { get; set; }
        //public string Company { get; set; }
        //public decimal Price { get; set; }
        public int Count { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
