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
using StockTraker.DAL.DTO;

namespace StockTraker
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        #region Declarations
        SalesBLL bllSales= new SalesBLL();
        public SalesDTO dtoSales= new SalesDTO();
        public SalesDetailDTO _dtoSalesDetail= new SalesDetailDTO();
        public bool _IsUpdate = false;
        bool validData, comboFull  = false;
        #endregion

        #region Functions
        void validationComponant()
        {
            validData = false;
            if (txtProductsaleamount.Text.Trim() == "")
                MessageBox.Show("Please enter sales amount.");
            else if (txtCustomername.Text.Trim() == "")
                MessageBox.Show("Please select customer from table.");
            else if (_dtoSalesDetail.CustomerID == 0)
                MessageBox.Show("Please select customer from table.");
            else if (txtProductname.Text.Trim() == "")
                MessageBox.Show("Please select product from table.");
            else if (_dtoSalesDetail.ProductID == 0)
                MessageBox.Show("Please select product from table.");
            else if (_dtoSalesDetail.StockAmount < Convert.ToInt32(txtProductsaleamount.Text))
                MessageBox.Show("You have bot enough product for sales.");
            else
                validData = true;
        }
        void clearData()
        {
            validData = false;
            txtCustomername.Text = "";
            txtCustomername.Clear();
            txtProductname.Text = "";
            txtProductname.Clear();
            txtProductsaleamount.Text = "";
            txtProductsaleamount.Clear();
            txtProductprice.Text = "";
            txtProductprice.Clear();
            txtProductstock.Text = "";
            txtProductstock.Clear();
            txtgrpCustomername.Text = "";
            txtgrpCustomername.Clear();

            fillDataGrid();
            fillComboBox();
        }

        void fillDataGrid()
        {
            bllSales = new SalesBLL();
            dtoSales = bllSales.Select();

            dgvCustomerList.DataSource = dtoSales.Customers;
            dgvCustomerList.Columns[0].Visible = false;
            dgvCustomerList.Columns[1].HeaderText = "Customer Name";

            dgvProductlist.DataSource = dtoSales.Products;
            dgvProductlist.Columns[0].HeaderText = "Product Name";
            dgvProductlist.Columns[1].HeaderText = "Category Name";
            dgvProductlist.Columns[2].HeaderText = "Stock Amount";
            dgvProductlist.Columns[3].HeaderText = "Price";
            dgvProductlist.Columns[4].Visible = false;
            dgvProductlist.Columns[5].Visible = false;
        }

        void fillComboBox()
        {
            bllSales = new SalesBLL();
            comboFull = false;
            dtoSales = bllSales.Select();
            cbCategory.DataSource = dtoSales.Categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            if (dtoSales.Categories.Count != 0)
                comboFull = true;
        }
        #endregion

        #region Form Load
        private void frmSales_Load(object sender, EventArgs e)
        {
            if(_IsUpdate)
            {
                pnlLeft.Hide();
                btnSave.Text = "Update";
                txtCustomername.Text = _dtoSalesDetail.CustomerName;
                txtProductname.Text= _dtoSalesDetail.ProductName;
                txtProductprice.Text = _dtoSalesDetail.Price.ToString();
                ProductDetailDTO product =dtoSales.Products.First(x=>x.ProductID == _dtoSalesDetail.ProductID);
                _dtoSalesDetail.StockAmount = product.StockAmount;
                txtProductstock.Text = _dtoSalesDetail.StockAmount.ToString();
                txtProductsaleamount.Text = _dtoSalesDetail.SalesAmount.ToString();
            }
            else if (!_IsUpdate)
            {
                fillComboBox();
                fillDataGrid();
            }
        }
        #endregion

        #region Selection change events
        private void txtProductsaleamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFull)
            {
                List<ProductDetailDTO> list = dtoSales.Products;
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cbCategory.SelectedValue)).ToList();
                dgvProductlist.DataSource = list;
                if(list.Count==0)
                {
                    txtProductname.Clear();
                    txtProductprice.Clear();
                    txtProductstock.Clear();
                }
            }
        }
        private void dgvProductlist_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _dtoSalesDetail.ProductName = dgvProductlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            _dtoSalesDetail.StockAmount = Convert.ToInt32(dgvProductlist.Rows[e.RowIndex].Cells[2].Value);
            _dtoSalesDetail.Price = Convert.ToInt32(dgvProductlist.Rows[e.RowIndex].Cells[3].Value);
            _dtoSalesDetail.ProductID = Convert.ToInt32(dgvProductlist.Rows[e.RowIndex].Cells[4].Value);
            _dtoSalesDetail.CategoryID = Convert.ToInt32(dgvProductlist.Rows[e.RowIndex].Cells[5].Value);
            
            txtProductname.Text = _dtoSalesDetail.ProductName;
            txtProductprice.Text = _dtoSalesDetail.Price.ToString();
            txtProductstock.Text = _dtoSalesDetail.StockAmount.ToString();
        }
        private void txtgrpCustomername_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dtoSales.Customers;
            list = list.Where(x => x.CustomerName.Contains(txtgrpCustomername.Text)).ToList();
            dgvCustomerList.DataSource = list;
            if (list.Count == 0)
                txtCustomername.Clear();
        }
        private void dgvCustomerList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _dtoSalesDetail.CustomerName = dgvCustomerList.Rows[e.RowIndex].Cells[1].Value.ToString();
            _dtoSalesDetail.CustomerID = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells[0].Value);

            txtCustomername.Text = _dtoSalesDetail.CustomerName;
        }
        #endregion

        #region Buttons Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            validationComponant();
            if (!_IsUpdate)
            {
                if (validData)
                {
                    _dtoSalesDetail.SalesAmount = Convert.ToInt32(txtProductsaleamount.Text);
                    _dtoSalesDetail.SalesDate = DateTime.Today;
                    if (bllSales.Insert(_dtoSalesDetail))
                    {
                        MessageBox.Show("Sales was added.");
                        clearData();
                    }
                }
            }
            else if (_IsUpdate)
            {
                if (_dtoSalesDetail.SalesAmount == Convert.ToInt32(txtProductsaleamount.Text))
                    MessageBox.Show("There is no change in data");

                int temp = _dtoSalesDetail.SalesAmount + _dtoSalesDetail.StockAmount;

                if (temp < Convert.ToInt32(txtProductsaleamount.Text))
                    MessageBox.Show("You have not enough product for sale.");
                else
                {
                    _dtoSalesDetail.SalesAmount = Convert.ToInt32(txtProductsaleamount.Text);
                    _dtoSalesDetail.StockAmount = temp - Convert.ToInt32(txtProductsaleamount.Text);
                    if (bllSales.Update(_dtoSalesDetail))
                    {
                        MessageBox.Show("Sales was updted.");
                        clearData();
                        _IsUpdate = false;
                        this.Close();
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
