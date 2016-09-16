using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        public DateTime DateTime { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }

        //Navigation Properties
        public virtual Order Order { get; set; }
    }
}