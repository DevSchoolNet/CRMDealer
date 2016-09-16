using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class Order
    {// invoice e A si order e B
        [Key]
        public int OrderId { get; set; }

        //Navigation Properties
        public virtual Customer Customer { get; set; }
        public virtual SpecialOffer SpecialOffer { get; set; }

        public Nullable<int> InvoiceId { get; set; }



        //Navigation Properties
        [ForeignKey("InvoiceId")]
        public virtual Invoice Invoice { get; set; }

        [InverseProperty("Order")]
        public virtual ICollection<Invoice> Invoices { get; set; }

        
        public virtual OrderDetail OrderDetail {get; set;}
    }
}