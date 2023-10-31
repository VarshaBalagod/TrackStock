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
    public partial class frmStockAlert : Form
    {
        public frmStockAlert()
        {
            InitializeComponent();
        }
        #region Declarations
        ProductBLL bllProduct=new ProductBLL();
        ProductDTO dtoProduct = new ProductDTO();
        #endregion

        #region Functions
        void fillDataGrid()
        {
            dtoProduct = bllProduct.Select();
            dtoProduct.Products = dtoProduct.Products.Where(x => x.StockAmount <= 10).ToList();
            dgvStockAlertList.DataSource = dtoProduct.Products;
            dgvStockAlertList.Columns[0].HeaderText = "Product Name";
            dgvStockAlertList.Columns[1].HeaderText = "Category Name";
            dgvStockAlertList.Columns[2].HeaderText = "Stock Amount";
            dgvStockAlertList.Columns[3].HeaderText = "Price";
            dgvStockAlertList.Columns[4].Visible = false;
            dgvStockAlertList.Columns[5].Visible = false;
            if (dtoProduct.Products.Count == 0)
            {
                frmDashBoard frmDashBoard = new frmDashBoard();
                this.Hide();
                frmDashBoard.ShowDialog();
            }
        }
        #endregion

        #region Form Load
        private void frmStockAlert_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }
        #endregion

        #region Selection change events
        #endregion

        #region Buttons Click
        private void btnOK_Click(object sender, EventArgs e)
        {
            frmDashBoard frmDashBoard = new frmDashBoard();
            this.Hide();
            frmDashBoard.ShowDialog();
        }
        #endregion

      
    }
}
