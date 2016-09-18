using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMModels
{
    public class Product
    {
        //Constructors
        public Product()
        {
            ProductsDetails = new List<ProductDetail>();
        }

        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }
        public int QuantityForSale { get; set; }
        public int QuantityForTest { get; set; }
        public string Model { get; set; }
        public decimal EngineCapacity { get; set; }
        public decimal Price { get; set; }

        //Navigation Properties
        public virtual ICollection<ProductDetail> ProductsDetails { get; set; }


        //Class methods
        public override bool Equals(object obj)
        {
            Product p = (Product)obj;

            try
            {
                if (Name.Equals(p.Name) && Model.Equals(p.Model) && (EngineCapacity == p.EngineCapacity))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }


            return false;
        }

    }
}