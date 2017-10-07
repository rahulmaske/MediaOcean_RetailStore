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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.KeyChar = '.';
            }

            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) && (this.txtPrice.Text.Contains(".") && this.txtPrice.Text.LastIndexOf('.') == this.txtPrice.Text.Length - 3))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) && !this.txtPrice.Text.Contains("."))
            {
                if (this.txtPrice.Text.Length == 5)
                {
                    e.Handled = true;
                }
                
            }

            if (e.KeyChar == '.')
            {
                if (this.txtPrice.Text.Length == 0)
                {
                    this.txtPrice.Text = "0.";
                    this.txtPrice.SelectionStart = 2;
                    e.Handled = true;
                }
                else if (this.txtPrice.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }
    }
}
