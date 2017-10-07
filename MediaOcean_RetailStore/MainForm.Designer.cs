namespace MediaOcean_RetailStore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewBill = new System.Windows.Forms.Button();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewBill
            // 
            this.btnNewBill.Location = new System.Drawing.Point(12, 22);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(75, 23);
            this.btnNewBill.TabIndex = 0;
            this.btnNewBill.Text = "New Bill";
            this.btnNewBill.UseVisualStyleBackColor = true;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(12, 82);
            this.txtBill.Multiline = true;
            this.txtBill.Name = "txtBill";
            this.txtBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBill.Size = new System.Drawing.Size(588, 238);
            this.txtBill.TabIndex = 1;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Location = new System.Drawing.Point(12, 57);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(0, 13);
            this.lblBillNo.TabIndex = 2;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 326);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Visible = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 359);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblBillNo);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.btnNewBill);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Button btnAddItem;
    }
}

