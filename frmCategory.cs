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
using StockTraker.DAL.DAO;

namespace StockTraker
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        #region Declarations
        CategoryBLL bllCategory = new CategoryBLL();
        public CategoryDetailDTO _dtoCategoryDetail = new CategoryDetailDTO();
        public bool _IsUpdate = false;
        bool validData = false;
        #endregion

        #region Functions
        void clearData()
        {
            txtCategoryname.Text = "";
            txtCategoryname.Clear();
            validData = false;
        }

        void validationComponant()
        {
            if (txtCategoryname.Text.Trim() == "")
                MessageBox.Show("Please enter category name.");
            else
                validData = true;
        }
        #endregion

        #region Form Load
        private void frmCategory_Load(object sender, EventArgs e)
        {
            if(_IsUpdate)
            {
                txtCategoryname.Text = _dtoCategoryDetail.CategoryName;
                btnSave.Text = "Update";
            }
        }
        #endregion

        #region Buttons Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            validationComponant();
            if (validData)
            {
                if (!_IsUpdate) //Add new category
                {
                    CategoryDetailDTO dtoCategoryDetail = new CategoryDetailDTO();
                    dtoCategoryDetail.CategoryName = txtCategoryname.Text;
                    if (bllCategory.Insert(dtoCategoryDetail))
                    {
                        MessageBox.Show("Category was added.");
                        clearData();
                    }
                }
                else if(_IsUpdate)// Update category
                {
                    if (_dtoCategoryDetail.CategoryName == txtCategoryname.Text)
                        MessageBox.Show("There is no change in record.");
                    else
                    {
                        _dtoCategoryDetail.CategoryName = txtCategoryname.Text;
                        if (bllCategory.Update(_dtoCategoryDetail))
                        {
                            MessageBox.Show("Category is updated.");
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
