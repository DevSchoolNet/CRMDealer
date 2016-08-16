using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class Order
    {
        public byte Id { get; set; }
        public Customer Customer { get; set; }
        public byte CustomerId { get; set; }
        public SpecialOffer SpecialOffer { get; set; }
        public byte SpecialOfferId { get; set; }
    }
}