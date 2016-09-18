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
        public static void AddProduct(string _name, string _model, decimal _engineCc, decimal _price, string _chasisSeries, bool _isForSale)
        {
            CRMContext crm = new CRMContext();

            //Product Table
            Product obj = new Product() { Name = _name, Model = _model, EngineCapacity = _engineCc, Price = _price, QuantityForSale = 0, QuantityForTest = 0 };

            //ProductDetail Table (Product -< ProductDetail == one-to-many)
            ProductDetail pd = null;

            //Flag for Product table
            bool isAlreadyInDB = false;

            //Check if Product obj already in database or not
            foreach (Product p in crm.Products)
            {
                if (p.Equals(obj))
                {
                    obj = p;
                    isAlreadyInDB = true;
                }
            }

            //Continue with obj Product
            if (_isForSale == true)
            {
                obj.QuantityForSale += 1;
                pd = new ProductDetail() { ChasisSeries = _chasisSeries, IsForSale = true };
            }
            else
            {
                obj.QuantityForTest += 1;
                pd = new ProductDetail() { ChasisSeries = _chasisSeries, IsForSale = false };
                pd.TestCar = new TestCar();
            }

            //Add ProductDetails object to obj 
            obj.ProductsDetails.Add(pd);

            //Add product to Product table if flag is false
            if (!isAlreadyInDB)
            {
                crm.Products.Add(obj);
            }

            crm.SaveChanges();
        }
    }
}
