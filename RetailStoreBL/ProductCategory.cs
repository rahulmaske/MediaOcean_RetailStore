using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreBL
{
    static class ProductCategory
    {
        public enum Category
        {
            CategoryA,
            CategoryB,
            CategoryC
        }

        static float[] Levy = new float[3] 
        {
            10.00F,         //CategoryA
            20.00F,         //CategoryB
            00.00F          //CategoryC
        };
        public static float GetLevyForCategory(int productCategory)
        {
            return Levy[productCategory];
        }
    }
}
