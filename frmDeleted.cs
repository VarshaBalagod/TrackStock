using StockTraker.BLL;
using StockTraker.DAL.DTO;
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
    public partial class frmDeleted : Form
    {
        public frmDeleted()
        {
            InitializeComponent();
        }
        #region Declarations
        SalesDTO dtoSales = new SalesDTO();
        CategoryBLL bllCategory= new CategoryBLL();
        ProductBLL bllProduct= new ProductBLL();
        CustomerBLL bllCutomer = new CustomerBLL();
        SalesBLL bllSales = new SalesBLL();
        CategoryDetailDTO dtoCategoryDetail = new CategoryDetailDTO();
        ProductDetailDTO dtoProductDetail = new ProductDetailDTO();
        CustomerDetailDTO dtoCustomerDetail = new CustomerDetailDTO();
        SalesDetailDTO dtoSalesDetail = new SalesDetailDTO();
        #endregion

        #region Functions
        void fillComboBox()
        {
            cbDeletedData.Items.Add("Category");
            cbDeletedData.Items.Add("Product");
            cbDeletedData.Items.Add("Customer");
            cbDeletedData.Items.Add("Sales");
        }
        void fillDataGridCategory()
        {
            bllSales = new SalesBLL();
            dtoSales = bllSales.Select(true);
            dgvDeletedList.DataSource = dtoSales.Categories;
            dgvDeletedList.Columns[0].Visible = false;
            dgvDeletedList.Columns[1].HeaderText = "Category Name";
        }

        void fillDataGridProduct()
        {
            bllSales = new SalesBLL();
            dtoSales = bllSales.Select(true);
            dgvDeletedList.DataSource = dtoSales.Products;
            dgvDeletedList.Columns[0].HeaderText = "Product Name";
            dgvDeletedList.Columns[1].HeaderText = "Category Name";
            dgvDeletedList.Columns[2].HeaderText = "Stock Amount";
            dgvDeletedList.Columns[3].HeaderText = "Price";
            dgvDeletedList.Columns[4].Visible = false;
            dgvDeletedList.Columns[5].Visible = false;
            dgvDeletedList.Columns[6].Visible = false;
        }

        void fillDataGridCustomer()
        {
            bllSales = new SalesBLL();
            dtoSales = bllSales.Select(true);
            dgvDeletedList.DataSource = dtoSales.Customers;
            dgvDeletedList.Columns[0].Visible = false;
            dgvDeletedList.Columns[1].HeaderText = "Customer Name";
        }

        void fillDataGridSales()
        {
            bllSales = new SalesBLL();
            dtoSales = bllSales.Select(true);
            dgvDeletedList.DataSource = dtoSales.Sales;
            dgvDeletedList.Columns[0].HeaderText = "Customer Name";
            dgvDeletedList.Columns[1].HeaderText = "Product Name";
            dgvDeletedList.Columns[2].HeaderText = "Category Name";
            dgvDeletedList.Columns[3].HeaderText = "Sales Amount";
            dgvDeletedList.Columns[4].HeaderText = "Price";
            dgvDeletedList.Columns[5].HeaderText = "Stock Amount";
            dgvDeletedList.Columns[6].HeaderText = "Sales Date";
            dgvDeletedList.Columns[7].Visible = false;
            dgvDeletedList.Columns[8].Visible = false;
            dgvDeletedList.Columns[9].Visible = false;
            dgvDeletedList.Columns[10].Visible = false;
            dgvDeletedList.Columns[11].Visible = false;
            dgvDeletedList.Columns[12].Visible = false;
            dgvDeletedList.Columns[13].Visible = false;
        }  
        #endregion

        #region Form Load
        private void frmDeleted_Load(object sender, EventArgs e)
        {
            fillComboBox();            
        }
        #endregion

        #region Selection change events
        private void cbDeletedData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDeletedData.SelectedIndex == 0)
                fillDataGridCategory();
            if (cbDeletedData.SelectedIndex == 1)
                fillDataGridProduct();
            if (cbDeletedData.SelectedIndex == 2)
                fillDataGridCustomer();
            if (cbDeletedData.SelectedIndex == 3)
                fillDataGridSales();
        }
        private void dgvDeletedList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cbDeletedData.SelectedIndex == 0)
            {
                dtoCategoryDetail.CategoryId = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[0].Value);
                dtoCategoryDetail.CategoryName = dgvDeletedList.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cbDeletedData.SelectedIndex == 1)
            {
                dtoProductDetail.ProductID = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[4].Value);
                dtoProductDetail.ProductName = dgvDeletedList.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtoProductDetail.CategoryID = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[5].Value);
                dtoProductDetail.ProductPrice = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[3].Value);
                dtoProductDetail.IsCategoryDeleted = Convert.ToBoolean(dgvDeletedList.Rows[e.RowIndex].Cells[6].Value);
            }
            else if (cbDeletedData.SelectedIndex == 2)
            {
                dtoCustomerDetail.CustomerID = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[0].Value);
                dtoCustomerDetail.CustomerName = dgvDeletedList.Rows[e.RowIndex].Cells[1].Value.ToString();
            }  
            else if (cbDeletedData.SelectedIndex == 3)
            {
                dtoSalesDetail.CustomerName = dgvDeletedList.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtoSalesDetail.ProductName = dgvDeletedList.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtoSalesDetail.CategoryName = dgvDeletedList.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtoSalesDetail.SalesAmount = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[3].Value);
                dtoSalesDetail.Price = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[4].Value);
                dtoSalesDetail.StockAmount = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[5].Value);
                dtoSalesDetail.SalesDate = Convert.ToDateTime(dgvDeletedList.Rows[e.RowIndex].Cells[6].Value);
                dtoSalesDetail.CustomerID = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[7].Value);
                dtoSalesDetail.ProductID = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[8].Value);
                dtoSalesDetail.CategoryID = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[9].Value);
                dtoSalesDetail.SalesID = Convert.ToInt32(dgvDeletedList.Rows[e.RowIndex].Cells[10].Value);
                dtoSalesDetail.IsCategoryDeleted = Convert.ToBoolean(dgvDeletedList.Rows[e.RowIndex].Cells[11].Value);
                dtoSalesDetail.IsProductDeleted = Convert.ToBoolean(dgvDeletedList.Rows[e.RowIndex].Cells[12].Value);
                dtoSalesDetail.IsCustomerDeleted = Convert.ToBoolean(dgvDeletedList.Rows[e.RowIndex].Cells[13].Value);
            }  
        }
        #endregion

        #region Buttons Click
        private void btnGetBack_Click(object sender, EventArgs e)
        {
            if (cbDeletedData.SelectedIndex == 0)
            {
                if(bllCategory.GetBack(dtoCategoryDetail))
                {
                    MessageBox.Show("Category was get back.");
                    fillDataGridCategory();
                }
            }
            else if (cbDeletedData.SelectedIndex == 1)
            {
                if (dtoProductDetail.IsCategoryDeleted)
                    MessageBox.Show("Category was first deleted get back category.");
                else if (bllProduct.GetBack(dtoProductDetail))
                {
                    MessageBox.Show("Product was get back.");
                    bllSales = new SalesBLL();
                    fillDataGridProduct();
                }
            }
            else if (cbDeletedData.SelectedIndex == 2)
            {
                if(bllCutomer.GetBack(dtoCustomerDetail)) 
                {
                    MessageBox.Show("Customer was get back.");
                    bllSales = new SalesBLL();
                    fillDataGridCustomer();
                }
            }
            else if (cbDeletedData.SelectedIndex == 3)
            {
                if (dtoSalesDetail.IsCategoryDeleted || dtoSalesDetail.IsProductDeleted || dtoSalesDetail.IsCustomerDeleted)
                {
                    if (dtoSalesDetail.IsCategoryDeleted)
                        MessageBox.Show("Category was first deleted get back category.");
                    else if (dtoSalesDetail.IsProductDeleted)
                        MessageBox.Show("Product was first deleted get back product.");
                    else if (dtoSalesDetail.IsCustomerDeleted)
                        MessageBox.Show("Customer was first deleted get back customer.");
                }
                else if (bllSales.GetBack(dtoSalesDetail))
                {
                    MessageBox.Show("Sales was get back.");
                    bllSales = new SalesBLL();
                    fillDataGridSales();
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
