using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class Prospect
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public Contact Contact { get; set; }
        public byte ContactId { get; set; }
    }
}