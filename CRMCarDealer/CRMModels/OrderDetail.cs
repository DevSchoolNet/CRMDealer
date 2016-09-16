using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace CRMModels
{//order e A si order detail B
    public class OrderDetail
    {
        [Key, Column(Order=0)]
        public int OrderId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductDetailId { get; set; }

        public int Quantity { get; set; }


        



        //Navigation Properties
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [InverseProperty("OrderDetail")]
        public virtual ICollection<Order> Orders { get; set; }


        //Navigation Properties
        public ProductDetail ProductDetail { get; set; }
        
    }
}