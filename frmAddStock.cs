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
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }

        #region Declarations
        ProductBLL bllProduct= new ProductBLL();
        ProductDTO dtoProduct= new ProductDTO();
        ProductDetailDTO dtoProductDetail = new ProductDetailDTO();
        bool validData, comboBoxFull = false;
        #endregion

        #region Functions
        void validationComponant()
        {
            if (txtProductstock.Text.Trim() == "")
                MessageBox.Show("Please enter stock amount.");
            else if (txtProductname.Text.Trim() == "")
                MessageBox.Show("Please select product from table.");
            else
                validData = true;
        }

        void clearData()
        {
            validData = false;
            txtProductname.Text = "";
            txtProductname.Clear();
            txtProductprice.Text = "";
            txtProductprice.Clear();
            txtProductstock.Text = "";
            txtProductstock.Clear();
            fillComboBox();
            fillDataGrid();
        }

        void fillDataGrid()
        {
            dtoProduct = bllProduct.Select();
            dgvProductList.DataSource = dtoProduct.Products;
            dgvProductList.Columns[0].HeaderText = "Product Name";
            dgvProductList.Columns[1].HeaderText = "Category Name";
            dgvProductList.Columns[2].HeaderText = "Stock Amount";
            dgvProductList.Columns[3].HeaderText = "Price";
            dgvProductList.Columns[4].Visible = false;
            dgvProductList.Columns[5].Visible = false;
        }

        void fillComboBox()
        {
            comboBoxFull = false;
            dtoProduct = bllProduct.Select();
            cbCategory.DataSource = dtoProduct.Categories;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.SelectedIndex = -1;
            if (dtoProduct.Categories.Count > 0)
                comboBoxFull = true;
        }
        #endregion

        #region Form Load
        private void frmAddStock_Load(object sender, EventArgs e)
        {
            fillComboBox();
            fillDataGrid();
        }
        #endregion

        #region Selection change events
        private void txtProductstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFull)
            {
                if (cbCategory.SelectedIndex != -1)
                {
                    List<ProductDetailDTO> list = dtoProduct.Products;
                    list = list.Where(x => x.CategoryID == Convert.ToInt32(cbCategory.SelectedValue)).ToList();
                    dgvProductList.DataSource = list;
                    if (list.Count == 0)
                    {
                        txtProductname.Clear();
                        txtProductstock.Clear();
                        txtProductprice.Clear();
                    }
                }
            }
        }
        private void dgvProductList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoProductDetail.ProductName = dgvProductList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProductname.Text = dtoProductDetail.ProductName;
            dtoProductDetail.CategoryName = dgvProductList.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtoProductDetail.StockAmount = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells[2].Value);
            dtoProductDetail.ProductPrice = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells[3].Value);
            txtProductprice.Text = dtoProductDetail.ProductPrice.ToString();
            dtoProductDetail.ProductID = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells[4].Value);
            //dtoProductDetail.CategoryID = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells[5].Value);
        }
        #endregion

        #region Buttons Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            validationComponant();
            if(validData)
            {
                int totalStock = dtoProductDetail.StockAmount;
                totalStock += Convert.ToInt32(txtProductstock.Text);
                dtoProductDetail.StockAmount = totalStock;
                if (bllProduct.Update(dtoProductDetail))
                {
                    MessageBox.Show("Product stock upated.");
                    clearData();
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

