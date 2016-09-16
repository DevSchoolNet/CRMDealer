using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }

        public string ChasisSeries { get; set; }
        public bool IsForSale { get; set; }

        //Navigation Properties
        public virtual Product Product { get; set; }
        public virtual TestCar TestCar { get; set; }
    }
}