using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class User
    {
        public byte Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Contact Contact { get; set; }
        public byte ContactId { get; set; }
    }
}