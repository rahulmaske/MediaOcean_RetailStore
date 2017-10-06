using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreBL
{
    public interface IProduct
    {
        string productName { get; set; }
        float GetProductPrice();
        float GetProductLevy();
    }
}
