using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreBL
{
    public static class ProductFactory
    {
        static public IProduct GetProduct(int productCategory, string productName, float price)
        {
            IProduct returnProduct = null;
            switch (productCategory)
            {
                case 0:
                    returnProduct = new ProductCategoryA(productName, price);
                    break;
                case 1:
                    returnProduct = new ProductCategoryB(productName, price);
                    break;
                case 2:
                    returnProduct = new ProductCategoryC(productName, price);
                    break;                

            }
            return returnProduct;
        }
    }
}
