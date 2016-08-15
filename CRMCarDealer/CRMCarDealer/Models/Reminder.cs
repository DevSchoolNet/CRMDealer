using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace CRMCarDealer.Models
{
    public class Reminder
    {
        public byte Id { get; set; }
        public Salesman Salesman { get; set; }
        public byte SalesmanId { get; set; }
        public Customer Customer { get; set; }
        public byte CustomerId { get; set; }
        public string Text { get; set; }
       
    }
}