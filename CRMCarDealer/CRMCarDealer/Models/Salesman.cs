using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CRMCarDealer.Models
{
    public class Salesman
    {
        public byte Id { get; set; }
        public User User { get; set; }
        public byte UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}