using RetailStoreBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaOcean_RetailStore
{
    public partial class AddItem : Form
    {
        Invoice billObj;
        public AddItem()
        {
            InitializeComponent();
        }

        public AddItem(Invoice currentBillObj)
        {
            billObj = currentBillObj;
        }
        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    IProduct newProduct = ProductFactory.GetProduct(1, "TestProduct", 3);
        //    billObj.AddItem(newProduct);            
        //}

        public string GetName()
        { return txtName.Text; }
        public int GetCategory()
        { return cbCategory.SelectedIndex; }
        public float GetPrice()
        { return float.Parse(txtPrice.Text); }
    }
}
