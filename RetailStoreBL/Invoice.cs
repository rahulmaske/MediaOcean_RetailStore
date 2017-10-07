using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreBL
{
    public class Invoice
    {
        static int billNo = 0;
        public List<IProduct> invoiceItems = new List<IProduct>();
        public int CreateNewBill()
        {
            return ++billNo;
        }
        public void AddItem(IProduct newItem)
        {
            invoiceItems.Add(newItem);
        }
        public string printBill()
        {
            float totalPrice = 0.0F, totalTax = 0.0F, total;
            StringBuilder outputString = new StringBuilder();

            outputString.Append("Sr.No\tProduct Name\t\t\tPrice\t\tTax");
            outputString.Append(Environment.NewLine);
            outputString.Append("----------------------------------------------------------------------------------------------------------------------------------------");
            outputString.Append(Environment.NewLine);

            foreach (IProduct singleProduct in invoiceItems)
            {
                
                outputString.Append((invoiceItems.IndexOf(singleProduct) + 1) + "\t" + singleProduct.productName.PadRight(17, ' ') + "\t\t\t" + singleProduct.GetProductPrice() + "\t\t" + singleProduct.GetSalesTaxForProduct() + " (@" + singleProduct.GetProductLevy() + "%)");
                outputString.Append(Environment.NewLine);
                totalPrice = totalPrice + singleProduct.GetProductPrice();
                totalTax = totalTax + singleProduct.GetSalesTaxForProduct();
            }

            outputString.Append("----------------------------------------------------------------------------------------------------------------------------------------");
            outputString.Append(Environment.NewLine);
            outputString.Append("Sub-Total\t\t\t\t\t"+ totalPrice + "\t\t" + totalTax);
            outputString.Append(Environment.NewLine);
            total = totalPrice + totalTax;
            outputString.Append(Environment.NewLine);
            outputString.Append("Total Amount: " + total);
            outputString.Append(Environment.NewLine);
            return outputString.ToString();
        }
    }
}
