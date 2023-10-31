namespace StockTraker
{
    partial class frmSalesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesList));
            this.dgvSalesList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductprice = new System.Windows.Forms.TextBox();
            this.lblProductprice = new System.Windows.Forms.Label();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.lblProductname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbPriceLess = new System.Windows.Forms.RadioButton();
            this.rbPriceEqual = new System.Windows.Forms.RadioButton();
            this.rbPriceMore = new System.Windows.Forms.RadioButton();
            this.txtSalesamount = new System.Windows.Forms.TextBox();
            this.lblSalesamount = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbSalesLess = new System.Windows.Forms.RadioButton();
            this.rbSalesEqual = new System.Windows.Forms.RadioButton();
            this.rbSalesMore = new System.Windows.Forms.RadioButton();
            this.gpStock = new System.Windows.Forms.GroupBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.dtSalesto = new System.Windows.Forms.DateTimePicker();
            this.dtSalesfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPrice = new System.Windows.Forms.GroupBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            this.gpStock.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.grpPrice.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesList.Location = new System.Drawing.Point(0, 241);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.ReadOnly = true;
            this.dgvSalesList.RowHeadersWidth = 62;
            this.dgvSalesList.RowTemplate.Height = 28;
            this.dgvSalesList.Size = new System.Drawing.Size(1269, 311);
            this.dgvSalesList.TabIndex = 5;
            this.dgvSalesList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesList_RowEnter);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(727, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(551, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 45);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(375, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(207, 118);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(200, 33);
            this.cbCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(12, 125);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 25);
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Category";
            // 
            // txtProductprice
            // 
            this.txtProductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductprice.Location = new System.Drawing.Point(621, 27);
            this.txtProductprice.Name = "txtProductprice";
            this.txtProductprice.Size = new System.Drawing.Size(200, 30);
            this.txtProductprice.TabIndex = 3;
            this.txtProductprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductprice_KeyPress);
            // 
            // lblProductprice
            // 
            this.lblProductprice.AutoSize = true;
            this.lblProductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductprice.Location = new System.Drawing.Point(462, 32);
            this.lblProductprice.Name = "lblProductprice";
            this.lblProductprice.Size = new System.Drawing.Size(141, 25);
            this.lblProductprice.TabIndex = 15;
            this.lblProductprice.Text = "Product Price";
            // 
            // txtProductname
            // 
            this.txtProductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductname.Location = new System.Drawing.Point(207, 65);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(200, 30);
            this.txtProductname.TabIndex = 1;
            // 
            // lblProductname
            // 
            this.lblProductname.AutoSize = true;
            this.lblProductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductname.Location = new System.Drawing.Point(12, 71);
            this.lblProductname.Name = "lblProductname";
            this.lblProductname.Size = new System.Drawing.Size(148, 25);
            this.lblProductname.TabIndex = 13;
            this.lblProductname.Text = "Product Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(199, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbPriceLess
            // 
            this.rbPriceLess.AutoSize = true;
            this.rbPriceLess.Location = new System.Drawing.Point(270, 29);
            this.rbPriceLess.Name = "rbPriceLess";
            this.rbPriceLess.Size = new System.Drawing.Size(83, 29);
            this.rbPriceLess.TabIndex = 2;
            this.rbPriceLess.TabStop = true;
            this.rbPriceLess.Text = "Less";
            this.rbPriceLess.UseVisualStyleBackColor = true;
            // 
            // rbPriceEqual
            // 
            this.rbPriceEqual.AutoSize = true;
            this.rbPriceEqual.Location = new System.Drawing.Point(42, 29);
            this.rbPriceEqual.Name = "rbPriceEqual";
            this.rbPriceEqual.Size = new System.Drawing.Size(92, 29);
            this.rbPriceEqual.TabIndex = 0;
            this.rbPriceEqual.TabStop = true;
            this.rbPriceEqual.Text = "Equal";
            this.rbPriceEqual.UseVisualStyleBackColor = true;
            // 
            // rbPriceMore
            // 
            this.rbPriceMore.AutoSize = true;
            this.rbPriceMore.Location = new System.Drawing.Point(159, 29);
            this.rbPriceMore.Name = "rbPriceMore";
            this.rbPriceMore.Size = new System.Drawing.Size(86, 29);
            this.rbPriceMore.TabIndex = 1;
            this.rbPriceMore.TabStop = true;
            this.rbPriceMore.Text = "More";
            this.rbPriceMore.UseVisualStyleBackColor = true;
            // 
            // txtSalesamount
            // 
            this.txtSalesamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesamount.Location = new System.Drawing.Point(621, 102);
            this.txtSalesamount.Name = "txtSalesamount";
            this.txtSalesamount.Size = new System.Drawing.Size(200, 30);
            this.txtSalesamount.TabIndex = 5;
            this.txtSalesamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesamount_KeyPress);
            // 
            // lblSalesamount
            // 
            this.lblSalesamount.AutoSize = true;
            this.lblSalesamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesamount.Location = new System.Drawing.Point(463, 107);
            this.lblSalesamount.Name = "lblSalesamount";
            this.lblSalesamount.Size = new System.Drawing.Size(147, 25);
            this.lblSalesamount.TabIndex = 22;
            this.lblSalesamount.Text = "Sales Amount";
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(1006, 171);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(144, 45);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(836, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 45);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbSalesLess
            // 
            this.rbSalesLess.AutoSize = true;
            this.rbSalesLess.Location = new System.Drawing.Point(270, 28);
            this.rbSalesLess.Name = "rbSalesLess";
            this.rbSalesLess.Size = new System.Drawing.Size(83, 29);
            this.rbSalesLess.TabIndex = 2;
            this.rbSalesLess.TabStop = true;
            this.rbSalesLess.Text = "Less";
            this.rbSalesLess.UseVisualStyleBackColor = true;
            // 
            // rbSalesEqual
            // 
            this.rbSalesEqual.AutoSize = true;
            this.rbSalesEqual.Location = new System.Drawing.Point(42, 29);
            this.rbSalesEqual.Name = "rbSalesEqual";
            this.rbSalesEqual.Size = new System.Drawing.Size(92, 29);
            this.rbSalesEqual.TabIndex = 0;
            this.rbSalesEqual.TabStop = true;
            this.rbSalesEqual.Text = "Equal";
            this.rbSalesEqual.UseVisualStyleBackColor = true;
            // 
            // rbSalesMore
            // 
            this.rbSalesMore.AutoSize = true;
            this.rbSalesMore.Location = new System.Drawing.Point(159, 29);
            this.rbSalesMore.Name = "rbSalesMore";
            this.rbSalesMore.Size = new System.Drawing.Size(86, 29);
            this.rbSalesMore.TabIndex = 1;
            this.rbSalesMore.TabStop = true;
            this.rbSalesMore.Text = "More";
            this.rbSalesMore.UseVisualStyleBackColor = true;
            // 
            // gpStock
            // 
            this.gpStock.Controls.Add(this.rbSalesLess);
            this.gpStock.Controls.Add(this.rbSalesEqual);
            this.gpStock.Controls.Add(this.rbSalesMore);
            this.gpStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpStock.Location = new System.Drawing.Point(841, 90);
            this.gpStock.Name = "gpStock";
            this.gpStock.Size = new System.Drawing.Size(392, 72);
            this.gpStock.TabIndex = 6;
            this.gpStock.TabStop = false;
            this.gpStock.Text = "Sales Amount";
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.chkDate);
            this.pnTop.Controls.Add(this.dtSalesto);
            this.pnTop.Controls.Add(this.dtSalesfrom);
            this.pnTop.Controls.Add(this.label3);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.txtCustomername);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.gpStock);
            this.pnTop.Controls.Add(this.txtSalesamount);
            this.pnTop.Controls.Add(this.lblSalesamount);
            this.pnTop.Controls.Add(this.btnClean);
            this.pnTop.Controls.Add(this.btnSearch);
            this.pnTop.Controls.Add(this.grpPrice);
            this.pnTop.Controls.Add(this.cbCategory);
            this.pnTop.Controls.Add(this.lblCategory);
            this.pnTop.Controls.Add(this.txtProductprice);
            this.pnTop.Controls.Add(this.lblProductprice);
            this.pnTop.Controls.Add(this.txtProductname);
            this.pnTop.Controls.Add(this.lblProductname);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1269, 241);
            this.pnTop.TabIndex = 0;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDate.Location = new System.Drawing.Point(727, 174);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(83, 29);
            this.chkDate.TabIndex = 9;
            this.chkDate.Text = "Date";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // dtSalesto
            // 
            this.dtSalesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSalesto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesto.Location = new System.Drawing.Point(501, 173);
            this.dtSalesto.Name = "dtSalesto";
            this.dtSalesto.Size = new System.Drawing.Size(200, 30);
            this.dtSalesto.TabIndex = 8;
            // 
            // dtSalesfrom
            // 
            this.dtSalesfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSalesfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSalesfrom.Location = new System.Drawing.Point(211, 173);
            this.dtSalesfrom.Name = "dtSalesfrom";
            this.dtSalesfrom.Size = new System.Drawing.Size(200, 30);
            this.dtSalesfrom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sales Date From";
            // 
            // txtCustomername
            // 
            this.txtCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomername.Location = new System.Drawing.Point(207, 12);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(200, 30);
            this.txtCustomername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Customer Name";
            // 
            // grpPrice
            // 
            this.grpPrice.Controls.Add(this.rbPriceLess);
            this.grpPrice.Controls.Add(this.rbPriceEqual);
            this.grpPrice.Controls.Add(this.rbPriceMore);
            this.grpPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrice.Location = new System.Drawing.Point(841, 12);
            this.grpPrice.Name = "grpPrice";
            this.grpPrice.Size = new System.Drawing.Size(392, 72);
            this.grpPrice.TabIndex = 4;
            this.grpPrice.TabStop = false;
            this.grpPrice.Text = "Price";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnDelete);
            this.pnlBottom.Controls.Add(this.btnUpdate);
            this.pnlBottom.Controls.Add(this.btnAdd);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 552);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1269, 100);
            this.pnlBottom.TabIndex = 1;
            // 
            // frmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 652);
            this.Controls.Add(this.dgvSalesList);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales List";
            this.Load += new System.EventHandler(this.frmSalesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            this.gpStock.ResumeLayout(false);
            this.gpStock.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.grpPrice.ResumeLayout(false);
            this.grpPrice.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductprice;
        private System.Windows.Forms.Label lblProductprice;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Label lblProductname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbPriceLess;
        private System.Windows.Forms.RadioButton rbPriceEqual;
        private System.Windows.Forms.RadioButton rbPriceMore;
        private System.Windows.Forms.TextBox txtSalesamount;
        private System.Windows.Forms.Label lblSalesamount;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbSalesLess;
        private System.Windows.Forms.RadioButton rbSalesEqual;
        private System.Windows.Forms.RadioButton rbSalesMore;
        private System.Windows.Forms.GroupBox gpStock;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox grpPrice;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.DateTimePicker dtSalesto;
        private System.Windows.Forms.DateTimePicker dtSalesfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}