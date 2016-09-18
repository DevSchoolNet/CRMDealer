using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMCarDealer.Models
{
    public class AddProductModel //De suprascris equals si eliminat intrari redundante in Product
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public decimal EngineCapacity { get; set; }

        public decimal Price { get; set; }

        [Required]
        public bool IsForSale { get; set; }

        [Required]
        public string ChasisSeries { get; set; }
    }
}