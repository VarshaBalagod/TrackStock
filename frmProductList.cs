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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        #region Declarations
        ProductBLL bllProduct = new ProductBLL();
        ProductDTO dtoProduct = new ProductDTO();
        ProductDetailDTO dtoProductDetail = new ProductDetailDTO();
        #endregion

        #region Functions
        void clearData() 
        {
            txtProductname.Text = "";
            txtProductname.Clear();
            txtProductprice.Text = "";
            txtProductprice.Clear();
            txtProductstock.Text = "";
            txtProductstock.Clear();
            rbPriceEqual.Checked = false;
            rbPriceMore.Checked = false;
            rbPriceLess.Checked = false;
            rbStockEqual.Checked = false;
            rbStockMore.Checked = false;
            rbStockLess.Checked = false;
            fillDataGrid();
            fillComboBox();
        }

        void fillDataGrid() 
        {
            bllProduct = new ProductBLL();
            dtoProduct = bllProduct.Select();
            dgvProductlist.DataSource = dtoProduct.Products;      
            dgvProductlist.Columns[0].HeaderText = "Product Name";
            dgvProductlist.Columns[1].HeaderText = "Category Name";
            dgvProductlist.Columns[2].HeaderText = "Stock Amount";
            dgvProductlist.Columns[3].HeaderText = "Price";            
            dgvProductlist.Columns[4].Visible = false;
            dgvProductlist.Columns[5].Visible = false;
            dgvProductlist.Columns[6].Visible = false;
        }

        void fillComboBox()
        {
            bllProduct = new ProductBLL();
            dtoProduct = bllProduct.Select();
            cbCategory.DataSource = dtoProduct.Categories;
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.SelectedIndex = -1;
        }
        #endregion

        #region Form Load
        private void frmProductList_Load(object sender, EventArgs e)
        {
            fillComboBox();
            fillDataGrid();
        }
        #endregion

        #region Selection change events
        private void txtProductprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }

        private void txtProductstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled |= General.IsNumber(e);
        }
        private void dgvProductlist_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoProductDetail.ProductID = Convert.ToInt32(dgvProductlist.Rows[e.RowIndex].Cells[4].Value);
            dtoProductDetail.ProductName = dgvProductlist.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtoProductDetail.CategoryID = Convert.ToInt32(dgvProductlist.Rows[e.RowIndex].Cells[5].Value);
            dtoProductDetail.ProductPrice = Convert.ToInt32(dgvProductlist.Rows[e.RowIndex].Cells[3].Value);
        }
        #endregion

        #region Buttons Click   
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProductDetailDTO> list = dtoProduct.Products;
            if (txtProductname.Text.Trim() != "")
                list = list.Where(x => x.ProductName.Contains(txtProductname.Text)).ToList();
            if (cbCategory.SelectedIndex != -1)
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cbCategory.SelectedValue)).ToList();
            if(txtProductprice.Text.Trim()!="")
            {
                if (rbPriceMore.Checked)
                    list = list.Where(x => x.ProductPrice > Convert.ToInt32(txtProductprice.Text)).ToList();
                else if (rbPriceLess.Checked)
                    list = list.Where(x => x.ProductPrice < Convert.ToInt32(txtProductprice.Text)).ToList();
                else if (rbPriceEqual.Checked)
                    list = list.Where(x => x.ProductPrice == Convert.ToInt32(txtProductprice.Text)).ToList();
                else
                    MessageBox.Show("Please check More, Less or Equal.");
            }
            if (txtProductstock.Text.Trim() != "")
            {
                if (rbStockMore.Checked)
                    list = list.Where(x => x.StockAmount > Convert.ToInt32(txtProductstock.Text)).ToList();
                else if (rbStockLess.Checked)
                    list = list.Where(x => x.StockAmount < Convert.ToInt32(txtProductstock.Text)).ToList();
                else if (rbStockEqual.Checked)
                    list = list.Where(x => x.StockAmount == Convert.ToInt32(txtProductstock.Text)).ToList();
                else
                    MessageBox.Show("Please check More, Less or Equal.");
            }

            dgvProductlist.DataSource = list;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
           clearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct._dtoProduct = dtoProduct;
            this.Hide();
            frmProduct.ShowDialog();
            this.Visible = true;
            clearData();
            fillComboBox();
            fillDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoProductDetail.ProductID == 0)
                MessageBox.Show("Please select product from table.");
            else
            {
                frmProduct frmProduct = new frmProduct();
                frmProduct._dtoProduct = dtoProduct;
                frmProduct._dtoProductDetail = dtoProductDetail;
                frmProduct._IsUpdate = true;
                this.Hide();
                frmProduct.ShowDialog();
                clearData();
                fillComboBox();
                fillDataGrid();
                this.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtoProductDetail.ProductID == 0)
                MessageBox.Show("Please select product from table.");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bllProduct.Delete(dtoProductDetail))
                    {
                        MessageBox.Show("Product was deleted.");
                        fillComboBox();
                        fillDataGrid();
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
