using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CRMCarDealer.Models
{
    public class OrderDetails
    {
        public byte Id { get; set; }
        public Product Product { get; set; }
        public byte ProductId { get; set; }
        public Order Order { get; set; }
        public byte OrderId { get; set; }
        public float Quantity { get; set; }
    }
}