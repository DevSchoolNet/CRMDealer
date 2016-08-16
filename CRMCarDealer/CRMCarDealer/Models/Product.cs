using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class Product
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public int QuantityForSale { get; set; }
        public int QuantityForTest { get; set; }
        public string Model { get; set; }
        public float EngineCapacity { get; set; }
        public float Price { get; set; }
    }
}