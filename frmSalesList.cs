using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTraker.BLL;
using StockTraker.DAL.DAO;
using StockTraker.DAL.DTO;


namespace StockTraker
{
    public partial class frmSalesList : Form
    {
        public frmSalesList()
        {
            InitializeComponent();
        }
        #region Declarations
        SalesBLL bllSales = new SalesBLL();
        SalesDTO dtoSales = new SalesDTO();
        SalesDetailDTO dtoSalesDetail = new SalesDetailDTO();
        #endregion

        #region Functions
        void clearData()
        {
            txtCustomername.Text = "";
            txtCustomername.Clear();
            txtProductname.Text = "";
            txtProductname.Clear();
            txtProductprice.Text = "";
            txtProductprice.Clear();
            txtSalesamount.Text = "";
            txtSalesamount.Clear();
            rbPriceEqual.Checked = false;
            rbPriceLess.Checked = false;
            rbPriceMore.Checked = false;
            rbSalesLess.Checked = false;
            rbSalesMore.Checked = false;
            rbSalesEqual.Checked = false;
            fillDataGrid();
            fillComboBox();
        }

        void fillDataGrid()
        {
            dtoSales = bllSales.Select();
            dgvSalesList.DataSource = dtoSales.Sales;
            dgvSalesList.Columns[0].HeaderText = "Customer Name";
            dgvSalesList.Columns[1].HeaderText = "Product Name";
            dgvSalesList.Columns[2].HeaderText = "Category Name";
            dgvSalesList.Columns[3].HeaderText = "Sales Amount";
            dgvSalesList.Columns[4].HeaderText = "Price";
            dgvSalesList.Columns[5].HeaderText = "Stock Amount";
            dgvSalesList.Columns[6].HeaderText = "Sales Date";
            dgvSalesList.Columns[7].Visible=false;
            dgvSalesList.Columns[8].Visible = false;
            dgvSalesList.Columns[9].Visible = false;
            dgvSalesList.Columns[10].Visible = false;
            dgvSalesList.Columns[11].Visible = false;
            dgvSalesList.Columns[12].Visible = false;
            dgvSalesList.Columns[13].Visible = false;
        }

        void fillComboBox()
        {           
            dtoSales = bllSales.Select();
            cbCategory.DataSource = dtoSales.Categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";          
        }
        #endregion

        #region Form Load
        private void frmSalesList_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            fillComboBox();
        }
        #endregion

        #region Selection change events
        private void txtProductprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void txtSalesamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }
        private void dgvSalesList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoSalesDetail.CustomerName = dgvSalesList.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtoSalesDetail.ProductName = dgvSalesList.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtoSalesDetail.CategoryName = dgvSalesList.Rows[e.RowIndex].Cells[2].Value.ToString();            
            dtoSalesDetail.SalesAmount = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[3].Value);
            dtoSalesDetail.Price = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[4].Value);
            dtoSalesDetail.StockAmount = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[5].Value);
            dtoSalesDetail.SalesDate = Convert.ToDateTime(dgvSalesList.Rows[e.RowIndex].Cells[6].Value);
            dtoSalesDetail.CustomerID = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[7].Value);
            dtoSalesDetail.ProductID = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[8].Value);
            dtoSalesDetail.CategoryID = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[9].Value);
            dtoSalesDetail.SalesID = Convert.ToInt32(dgvSalesList.Rows[e.RowIndex].Cells[10].Value);
        }
        #endregion

        #region Buttons Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<SalesDetailDTO> list = dtoSales.Sales;
            if (txtCustomername.Text.Trim() != "")
                list = list.Where(x => x.CustomerName.Contains(txtCustomername.Text)).ToList();
            if (txtProductname.Text.Trim() != "")
                list = list.Where(x => x.ProductName.Contains(txtProductname.Text)).ToList();
            if (cbCategory.SelectedIndex != -1)
                list = list.Where(x => x.CategoryID == (Convert.ToInt32(cbCategory.SelectedValue))).ToList();
            if(txtProductprice.Text.Trim()!="")
            {
                if (rbPriceEqual.Checked)
                    list = list.Where(x => x.Price == Convert.ToInt32(txtProductprice.Text)).ToList();
                if (rbPriceMore.Checked)
                    list = list.Where(x => x.Price > Convert.ToInt32(txtProductprice.Text)).ToList();
                if (rbPriceLess.Checked)
                    list = list.Where(x => x.Price < Convert.ToInt32(txtProductprice.Text)).ToList();
            }
            if (txtSalesamount.Text.Trim() != "")
            {
                if (rbSalesEqual.Checked)
                    list = list.Where(x => x.SalesAmount == Convert.ToInt32(txtSalesamount.Text)).ToList();
                if (rbSalesMore.Checked)
                    list = list.Where(x => x.SalesAmount > Convert.ToInt32(txtSalesamount.Text)).ToList();
                if (rbSalesLess.Checked)
                    list = list.Where(x => x.SalesAmount < Convert.ToInt32(txtSalesamount.Text)).ToList();
            }
            if (chkDate.Checked)
                list = list.Where(x => x.SalesDate > dtSalesfrom.Value && x.SalesDate < dtSalesto.Value).ToList();
            //if (list.Count != 0)
                dgvSalesList.DataSource = list;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSales frmSales = new frmSales();
            this.Hide();
            frmSales.ShowDialog();
            this.Visible = true;
            clearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoSalesDetail.SalesID == 0)
                MessageBox.Show("Please select sales record from table.");
            else
            {
                frmSales frmSales = new frmSales();
                frmSales._dtoSalesDetail = dtoSalesDetail;
                frmSales.dtoSales = dtoSales;
                frmSales._IsUpdate = true;
                this.Hide();
                frmSales.ShowDialog();
                this.Visible = true;
                clearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtoSalesDetail.SalesID == 0)
                MessageBox.Show("Select sales from table for delete.");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bllSales.Delete(dtoSalesDetail))
                    {
                        MessageBox.Show("Sales record was deleted.");
                        clearData();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

     
    }
}
