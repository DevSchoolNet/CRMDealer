using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class SpecialOffer
    {
        [Key]
        public int SpecialOfferId { get; set; }

        public decimal Discount { get; set; }
        public string Details { get; set; }

        public Nullable<int> OrderId { get; set; }



        //Navigation Properties
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [InverseProperty("SpecialOffer")]
        public virtual ICollection<Order> Orders { get; set; }

        //Navigation Properties

    }
}