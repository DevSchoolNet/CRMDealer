using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class AddReminderModel
    {
        public string Text { get; set; }
        public string SalesmanName { get; set; }
        public string SalesmanSurname { get; set; }
        public int CustomerId { get; set; }
    }
}