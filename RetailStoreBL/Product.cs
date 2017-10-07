using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreBL
{
    class Product
    {
    }
    public class ProductCategoryA : IProduct
    {
        public string productName   { get; set; }
        public float  productPrice { get; set; }

        public ProductCategoryA(string pName, float pPrice)
        {
            productName = pName;
            productPrice = pPrice;
        }
        
        public float GetProductPrice()
        {
            return productPrice;
        }

        public float GetProductLevy()
        {
            return 10.00F;
        }
        public float GetSalesTaxForProduct()
        {
            return (productPrice * 10.00F) / 100;
        }
    }

    class ProductCategoryB : IProduct
    {
        public string productName { get; set; }
        public float productPrice { get; set; }

        public ProductCategoryB(string pName, float pPrice)
        {
            productName = pName;
            productPrice = pPrice;
        }

        public float GetProductPrice()
        {
            return productPrice;
        }

        public float GetProductLevy()
        {
            return 20.00F;
        }
        public float GetSalesTaxForProduct()
        {
            return (productPrice * 20.00F) / 100;
        }
    }

    class ProductCategoryC : IProduct
    {
        public string productName { get; set; }
        public float productPrice { get; set; }

        public ProductCategoryC(string pName, float pPrice)
        {
            productName = pName;
            productPrice = pPrice;
        }

        public float GetProductPrice()
        {
            return productPrice;
        }

        public float GetProductLevy()
        {
            return 0;
        }
        public float GetSalesTaxForProduct()
        {
            return 0;
        }
    }
}
