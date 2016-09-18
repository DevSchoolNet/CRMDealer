using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class AddProductModel //De suprascris equals si eliminat intrari redundante in Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal EngineCapacity { get; set; }
        public decimal Price { get; set; }

        //<Petru>
        public bool IsForSale { get; set; }
        //</Petru>

        public string ChasisSeries { get; set; }
    }
}