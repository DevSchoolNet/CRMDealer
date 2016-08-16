using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class SpecialOffer
    {
        public byte Id { get; set; }
        public float Discount { get; set; }
        public string Details { get; set; }
    }
}