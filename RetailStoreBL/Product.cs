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
            return ProductCategory.GetLevyForCategory((int)ProductCategory.Category.CategoryA);
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
            return ProductCategory.GetLevyForCategory((int)ProductCategory.Category.CategoryB);
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
            return ProductCategory.GetLevyForCategory((int) ProductCategory.Category.CategoryC);
        }
    }
}
