using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class Customer
    {
        //Constructors
        public Customer()
        {
            this.Reminders = new List<Reminder>();
            this.Orders = new List<Order>();
        }

        [Key]
        public int CustomerId { get; set; }


        public Nullable<int> ProspectId { get; set; }



        //Navigation Properties
        [ForeignKey("ProspectId")]
        public virtual Prospect Prospect { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Prospect> Prospects { get; set; }

        //Navigation Properties
        public virtual User User { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Reminder> Reminders { get; set; }
    }
}