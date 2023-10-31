using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTraker
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }
        #region Declarations
        #endregion

        #region Functions
        #endregion

        #region Form Load
        private void frmDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Selection change events
        #endregion

        #region Buttons Click
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerList frmCustomerList = new frmCustomerList();
            this.Hide();
            frmCustomerList.ShowDialog();
            this.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProductList frmProductList = new frmProductList();
            this.Hide();
            frmProductList.ShowDialog();
            this.Visible = true;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSalesList frmSalesList = new frmSalesList();
            this.Hide();
            frmSalesList.ShowDialog();
            this.Visible = true;
        }

        private void btnAddstock_Click(object sender, EventArgs e)
        {
            frmAddStock frmAddStock = new frmAddStock();
            this.Hide();
            frmAddStock.ShowDialog();
            this.Visible = true;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoryList frmCategoryList = new frmCategoryList();
            this.Hide();
            frmCategoryList.ShowDialog();
            this.Visible = true;
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            frmDeleted frmDeleted = new frmDeleted();
            this.Hide();
            frmDeleted.ShowDialog();
            this.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        
    }
}
