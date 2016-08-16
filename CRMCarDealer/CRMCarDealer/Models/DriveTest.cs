using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class DriveTest
    {
        public byte Id { get; set; }
        public Prospect Prospect { get; set; }
        public byte ProspectId { get; set; }
        public DateTime DateTime { get; set; }
        public Salesman Salesman { get; set; }
        public byte SalesmanId { get; set; }
        public TestCar TestCar { get; set; }
        public byte TestCarId { get; set; }
        public string Details { get; set; }
    }
}