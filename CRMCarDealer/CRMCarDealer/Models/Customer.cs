using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class Customer
    {
        public byte Id { get; set; }
        public User User { get; set; }
        public byte UserId { get; set; }
    }
}