using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class ProductDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte ChasisSeries { get; set; }
        public Product Product { get; set; }
        public byte ProductId { get; set; }
        public bool IsForSale { get; set; }
    }
}