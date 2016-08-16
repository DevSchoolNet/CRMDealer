using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class Invoice
    {
        public byte Id { get; set; }
        public Order Order { get; set; }
        public byte OrderId { get; set; }
        public DateTime DateTime { get; set; }
        public string Series { get; set; }
        public long Number { get; set; }
    }
}