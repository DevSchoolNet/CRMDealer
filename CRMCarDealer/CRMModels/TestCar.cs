using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class TestCar
    {
        [Key]
        public int TestCarId { get; set; }


        public Nullable<int> ProductDetailId { get; set; }



        //Navigation Properties
        [ForeignKey("ProductDetailId")]
        public virtual ProductDetail ProductDetail { get; set; }

        [InverseProperty("TestCar")]
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }

        //Navigation Properties
        
    }
}