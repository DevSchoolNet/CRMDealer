using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace CRMModels
{
    public class Reminder
    {
        [Key]
        public int ReminderId { get; set; }

        public string Text { get; set; }

        //Navigation Properties
        public virtual Salesman Salesman { get; set; }
        public virtual Customer Customer { get; set; }

    }
}