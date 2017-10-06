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
    public partial class MainForm : Form
    {
        Invoice billObj = null;
        int billNo;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            billObj = null;
            billObj = new Invoice();
            billNo = billObj.CreateNewBill();
            lblBillNo.Text = "Invoice No: " + billNo;
            btnAddItem.Visible = true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem frmAddItem = new AddItem();
            
            DialogResult dr = frmAddItem.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frmAddItem.Close();
            }
            else if (dr == DialogResult.OK)
            {
                IProduct newProduct = ProductFactory.GetProduct(frmAddItem.GetCategory(), frmAddItem.GetName(), frmAddItem.GetPrice());
                billObj.AddItem(newProduct);
                UpdateBill();
                frmAddItem.Close();
            }
            
        }
        private void UpdateBill()
        {
            txtBill.Text = billObj.printBill();
        }
    }
}
