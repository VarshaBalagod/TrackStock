using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTraker.DAL.DTO;
using StockTraker.BLL;

namespace StockTraker
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }


        #region Declarations
        public ProductDTO _dtoProduct = new ProductDTO();
        ProductBLL bllProduct = new ProductBLL();
        public ProductDetailDTO _dtoProductDetail = new ProductDetailDTO();
        public bool _IsUpdate = false;
        bool validData = false;
        #endregion

        #region Functions
        void validationComponant()
        {
            if (txtProductname.Text.Trim() == "")
                MessageBox.Show("Please enter Product name.");
            else if (txtProductdprice.Text.Trim() == "")
                MessageBox.Show("Please enter product price.");
            else if (cbCategory.SelectedIndex == -1)
                MessageBox.Show("Please select category.");
            else
                validData = true;
        }

        void clearData()
        {
            validData = false;
            txtProductdprice.Text = "";
            txtProductdprice.Clear();
            txtProductname.Text = "";
            txtProductname.Clear();
            fillComboBox();
        }

        void fillComboBox()
        {
            cbCategory.DataSource = _dtoProduct.Categories;
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.SelectedIndex = -1;
        }
        #endregion

        #region Form Load
        private void frmProduct_Load(object sender, EventArgs e)
        {
            fillComboBox();
            if(_IsUpdate)
            {
                btnSave.Text = "Update";
                txtProductname.Text=_dtoProductDetail.ProductName;
                txtProductdprice.Text = _dtoProductDetail.ProductPrice.ToString();
                cbCategory.SelectedValue = _dtoProductDetail.CategoryID;
            }
        }
        #endregion

        #region Selection change events
        private void txtProductprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.IsNumber(e);
        }
        #endregion

        #region Buttons Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            validationComponant();
            if(validData)
            {
                if (!_IsUpdate)
                {
                    ProductDetailDTO dtoProductDetail = new ProductDetailDTO();
                    dtoProductDetail.ProductName = txtProductname.Text;
                    dtoProductDetail.ProductPrice = Convert.ToInt32(txtProductdprice.Text);
                    dtoProductDetail.CategoryID = Convert.ToInt32(cbCategory.SelectedValue);
                    if (bllProduct.Insert(dtoProductDetail))
                    {
                        MessageBox.Show("Product was added.");
                        clearData();
                    }
                }
                else if (_IsUpdate)
                {
                    if (_dtoProductDetail.ProductName == txtProductname.Text &&
                        _dtoProductDetail.ProductPrice == Convert.ToInt32(txtProductdprice.Text) &&
                       _dtoProductDetail.CategoryID == Convert.ToInt32(cbCategory.SelectedValue))
                        MessageBox.Show("There is no change in record.");
                    else
                    {
                        _dtoProductDetail.ProductName = txtProductname.Text;
                        _dtoProductDetail.ProductPrice = Convert.ToInt32(txtProductdprice.Text);
                        _dtoProductDetail.CategoryID = Convert.ToInt32(cbCategory.SelectedValue);
                        if (bllProduct.Update(_dtoProductDetail))
                        {
                            MessageBox.Show("Product was updated.");
                            clearData();
                            _IsUpdate = false;
                            this.Close();
                        }
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
