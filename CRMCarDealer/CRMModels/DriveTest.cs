using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class DriveTest
    {
        [Key]
        public int DriveTestId { get; set; }

        public string Details { get; set; }
        public DateTime DateTime { get; set; }

        //Navigation Properties
        public virtual Prospect Prospect { get; set; }
        public virtual Salesman Salesman { get; set; }
        public virtual TestCar TestCar { get; set; }


    }
}