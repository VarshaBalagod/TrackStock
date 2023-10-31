namespace StockTraker
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.pnlLeftBottom = new System.Windows.Forms.Panel();
            this.txtgrpCustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.dgvProductlist = new System.Windows.Forms.DataGridView();
            this.panLeftTop = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductstock = new System.Windows.Forms.TextBox();
            this.lblProductstock = new System.Windows.Forms.Label();
            this.txtProductprice = new System.Windows.Forms.TextBox();
            this.lblProductprice = new System.Windows.Forms.Label();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.lblProductname = new System.Windows.Forms.Label();
            this.txtProductsaleamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.lblCustomername = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.pnlLeftBottom.SuspendLayout();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductlist)).BeginInit();
            this.panLeftTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.grpCustomer);
            this.pnlLeft.Controls.Add(this.grpProduct);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLeft.Location = new System.Drawing.Point(503, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(595, 697);
            this.pnlLeft.TabIndex = 0;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.dgvCustomerList);
            this.grpCustomer.Controls.Add(this.pnlLeftBottom);
            this.grpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(3, 333);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(589, 361);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerList.Location = new System.Drawing.Point(3, 99);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersWidth = 62;
            this.dgvCustomerList.RowTemplate.Height = 28;
            this.dgvCustomerList.Size = new System.Drawing.Size(583, 259);
            this.dgvCustomerList.TabIndex = 0;
            this.dgvCustomerList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_RowEnter);
            // 
            // pnlLeftBottom
            // 
            this.pnlLeftBottom.Controls.Add(this.txtgrpCustomername);
            this.pnlLeftBottom.Controls.Add(this.label2);
            this.pnlLeftBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftBottom.Location = new System.Drawing.Point(3, 26);
            this.pnlLeftBottom.Name = "pnlLeftBottom";
            this.pnlLeftBottom.Size = new System.Drawing.Size(583, 73);
            this.pnlLeftBottom.TabIndex = 1;
            // 
            // txtgrpCustomername
            // 
            this.txtgrpCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrpCustomername.Location = new System.Drawing.Point(226, 18);
            this.txtgrpCustomername.Name = "txtgrpCustomername";
            this.txtgrpCustomername.Size = new System.Drawing.Size(200, 30);
            this.txtgrpCustomername.TabIndex = 0;
            this.txtgrpCustomername.TextChanged += new System.EventHandler(this.txtgrpCustomername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Name";
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.dgvProductlist);
            this.grpProduct.Controls.Add(this.panLeftTop);
            this.grpProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduct.Location = new System.Drawing.Point(0, 0);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(592, 327);
            this.grpProduct.TabIndex = 0;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // dgvProductlist
            // 
            this.dgvProductlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductlist.Location = new System.Drawing.Point(3, 92);
            this.dgvProductlist.Name = "dgvProductlist";
            this.dgvProductlist.ReadOnly = true;
            this.dgvProductlist.RowHeadersWidth = 62;
            this.dgvProductlist.RowTemplate.Height = 28;
            this.dgvProductlist.Size = new System.Drawing.Size(586, 232);
            this.dgvProductlist.TabIndex = 0;
            this.dgvProductlist.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductlist_RowEnter);
            // 
            // panLeftTop
            // 
            this.panLeftTop.Controls.Add(this.lblCategory);
            this.panLeftTop.Controls.Add(this.cbCategory);
            this.panLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLeftTop.Location = new System.Drawing.Point(3, 26);
            this.panLeftTop.Name = "panLeftTop";
            this.panLeftTop.Size = new System.Drawing.Size(586, 66);
            this.panLeftTop.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(16, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 25);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(229, 22);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 33);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // txtProductstock
            // 
            this.txtProductstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductstock.Location = new System.Drawing.Point(264, 185);
            this.txtProductstock.Name = "txtProductstock";
            this.txtProductstock.ReadOnly = true;
            this.txtProductstock.Size = new System.Drawing.Size(200, 30);
            this.txtProductstock.TabIndex = 26;
            // 
            // lblProductstock
            // 
            this.lblProductstock.AutoSize = true;
            this.lblProductstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductstock.Location = new System.Drawing.Point(12, 190);
            this.lblProductstock.Name = "lblProductstock";
            this.lblProductstock.Size = new System.Drawing.Size(147, 25);
            this.lblProductstock.TabIndex = 30;
            this.lblProductstock.Text = "Product Stock";
            // 
            // txtProductprice
            // 
            this.txtProductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductprice.Location = new System.Drawing.Point(264, 130);
            this.txtProductprice.Name = "txtProductprice";
            this.txtProductprice.ReadOnly = true;
            this.txtProductprice.Size = new System.Drawing.Size(200, 30);
            this.txtProductprice.TabIndex = 25;
            // 
            // lblProductprice
            // 
            this.lblProductprice.AutoSize = true;
            this.lblProductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductprice.Location = new System.Drawing.Point(12, 135);
            this.lblProductprice.Name = "lblProductprice";
            this.lblProductprice.Size = new System.Drawing.Size(141, 25);
            this.lblProductprice.TabIndex = 28;
            this.lblProductprice.Text = "Product Price";
            // 
            // txtProductname
            // 
            this.txtProductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductname.Location = new System.Drawing.Point(264, 75);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.ReadOnly = true;
            this.txtProductname.Size = new System.Drawing.Size(200, 30);
            this.txtProductname.TabIndex = 23;
            // 
            // lblProductname
            // 
            this.lblProductname.AutoSize = true;
            this.lblProductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductname.Location = new System.Drawing.Point(12, 80);
            this.lblProductname.Name = "lblProductname";
            this.lblProductname.Size = new System.Drawing.Size(148, 25);
            this.lblProductname.TabIndex = 27;
            this.lblProductname.Text = "Product Name";
            // 
            // txtProductsaleamount
            // 
            this.txtProductsaleamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductsaleamount.Location = new System.Drawing.Point(264, 240);
            this.txtProductsaleamount.Name = "txtProductsaleamount";
            this.txtProductsaleamount.Size = new System.Drawing.Size(200, 30);
            this.txtProductsaleamount.TabIndex = 0;
            this.txtProductsaleamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductsaleamount_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Product Sales Amount";
            // 
            // txtCustomername
            // 
            this.txtCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomername.Location = new System.Drawing.Point(264, 20);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.ReadOnly = true;
            this.txtCustomername.Size = new System.Drawing.Size(200, 30);
            this.txtCustomername.TabIndex = 33;
            // 
            // lblCustomername
            // 
            this.lblCustomername.AutoSize = true;
            this.lblCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomername.Location = new System.Drawing.Point(12, 25);
            this.lblCustomername.Name = "lblCustomername";
            this.lblCustomername.Size = new System.Drawing.Size(167, 25);
            this.lblCustomername.TabIndex = 34;
            this.lblCustomername.Text = "Customer Name";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(244, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(65, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 697);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCustomername);
            this.Controls.Add(this.lblCustomername);
            this.Controls.Add(this.txtProductsaleamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductstock);
            this.Controls.Add(this.lblProductstock);
            this.Controls.Add(this.txtProductprice);
            this.Controls.Add(this.lblProductprice);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.lblProductname);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.pnlLeft.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.pnlLeftBottom.ResumeLayout(false);
            this.pnlLeftBottom.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductlist)).EndInit();
            this.panLeftTop.ResumeLayout(false);
            this.panLeftTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftBottom;
        private System.Windows.Forms.Panel panLeftTop;
        private System.Windows.Forms.TextBox txtProductstock;
        private System.Windows.Forms.Label lblProductstock;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductprice;
        private System.Windows.Forms.Label lblProductprice;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Label lblProductname;
        private System.Windows.Forms.TextBox txtProductsaleamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label lblCustomername;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.DataGridView dgvProductlist;
        private System.Windows.Forms.TextBox txtgrpCustomername;
        private System.Windows.Forms.Label label2;
    }
}