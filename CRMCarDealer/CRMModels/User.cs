using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string PassWord { get; set; }


        public Nullable<int> ContactId { get; set; }



        //Navigation Properties
        [ForeignKey("ContactId")]
        public virtual Contact Contact { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Contact> Contacts { get; set; }

        public Nullable<int> CustomerId { get; set; }

        //Navigation Properties
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Customer> Customers { get; set; }

        public Nullable<int> SalesmanId { get; set; }

        //Navigation Properties
        [ForeignKey("SalesmanId")]
        public virtual Salesman Salesman { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Salesman> Salesmen { get; set; }

        
    }
}