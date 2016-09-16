using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CRMModels
{
    public class Salesman
    {
        //Constructors
        public Salesman()
        {
            this.DriveTests = new List<DriveTest>();
            this.Reminders = new List<Reminder>();
        }

        [Key]
        public int SalesmanId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        //Navigation Properties
        public virtual User User { get; set; }
        public virtual ICollection<DriveTest> DriveTests { get; set; }
        public virtual ICollection<Reminder> Reminders { get; set; }
    }
}