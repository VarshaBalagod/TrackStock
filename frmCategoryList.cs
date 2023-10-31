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
    public partial class frmCategoryList : Form
    {
        public frmCategoryList()
        {
            InitializeComponent();
        }
        #region Declarations
        frmCategory frmCategory = new frmCategory();
        CategoryDTO dtoCategory = new CategoryDTO();
        CategoryBLL bllCategory = new CategoryBLL();
        CategoryDetailDTO dtoCategoryDetail = new CategoryDetailDTO();
        #endregion

        #region Functions
        void fillDataGrid()
        {
            bllCategory = new CategoryBLL();
            dtoCategory = bllCategory.Select();
            dgvCategoryList.DataSource = dtoCategory.Categories;
            dgvCategoryList.Columns[0].Visible = false;
            dgvCategoryList.Columns[1].HeaderText = "Category Name";
        }
        #endregion

        #region Form Load
        private void frmCategoryList_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }
        #endregion

        #region Selection change events
        private void txtCategoryname_TextChanged(object sender, EventArgs e)
        {
            List<CategoryDetailDTO> listDetail = dtoCategory.Categories;
            listDetail = listDetail.Where(x => x.CategoryName.Contains(txtCategoryname.Text)).ToList();
            dgvCategoryList.DataSource = listDetail;
        }
        private void dgvCategoryList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoCategoryDetail = new CategoryDetailDTO();
            dtoCategoryDetail.CategoryId = Convert.ToInt32(dgvCategoryList.Rows[e.RowIndex].Cells[0].Value);
            dtoCategoryDetail.CategoryName = dgvCategoryList.Rows[e.RowIndex].Cells[1].Value.ToString();            
        }
        #endregion

        #region Buttons Click   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCategory = new frmCategory();
            this.Hide();
            frmCategory.ShowDialog();
            this.Visible = true;
            fillDataGrid();
        }       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoCategoryDetail.CategoryId == 0)
                MessageBox.Show("Please select record from table.");
            else
            {
                frmCategory = new frmCategory();
                frmCategory._dtoCategoryDetail = dtoCategoryDetail;
                frmCategory._IsUpdate= true;
                this.Hide();
                frmCategory.ShowDialog();
                this.Visible = true;
                fillDataGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtoCategoryDetail.CategoryId == 0)
                MessageBox.Show("Please select record from table.");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    if(bllCategory.Delete(dtoCategoryDetail))
                    {
                        MessageBox.Show("Category was delete.");
                        fillDataGrid();
                        txtCategoryname.Text = "";
                        txtCategoryname.Clear();
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
