using CRMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class ProductService
    {
        public static void AddProduct(string _name, string _model, decimal _engineCc, decimal _price, string _chasisSeries)
        {
            CRMContext crm = new CRMContext();

            Product obj = new Product() { Name = _name, Model = _model, EngineCapacity = _engineCc, Price = _price, QuantityForSale = 1, QuantityForTest = 1 };
            obj.ProductsDetails.Add(new ProductDetail() { ChasisSeries = _chasisSeries, IsForSale = true });
            
            crm.Products.Add(obj);
            crm.SaveChanges();
        }
    }
}
