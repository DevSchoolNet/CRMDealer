using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class TestCar
    {
        public byte Id { get; set; }
        public ProductDetails ProductDetails { get; set; }
        public byte ProductDetailsChasisSeries { get; set; }
    }
}