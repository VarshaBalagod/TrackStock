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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        #region Declarations
        CustomerDTO dtoCustomer = new CustomerDTO();
        CustomerBLL bllCustomer = new CustomerBLL();
        CustomerDetailDTO dtoCustomerDetail = new CustomerDetailDTO();
        #endregion

        #region Functions
        void fillDataGrid()
        {
            bllCustomer = new CustomerBLL();
            dtoCustomer = bllCustomer.Select();
            dgvCustomerList.DataSource = dtoCustomer.Customers;
            dgvCustomerList.Columns[0].Visible = false;
            dgvCustomerList.Columns[1].HeaderText = "Customer Name";
        }
        #endregion

        #region Form Load
        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }
        #endregion

        #region Selection change events
        private void txtCustomername_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = new List<CustomerDetailDTO>();
            list = list.Where(x => x.CustomerName.Contains(txtCustomername.Text)).ToList();
            dgvCustomerList.DataSource = list;
        }
        private void dgvCustomerList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtoCustomerDetail.CustomerID = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells[0].Value);
            dtoCustomerDetail.CustomerName = dgvCustomerList.Rows[e.RowIndex].Cells[1].Value.ToString();           
        }
        #endregion

        #region Buttons Click   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            this.Hide();
            frmCustomer.ShowDialog();
            this.Visible = true;
            fillDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtoCustomerDetail.CustomerID == 0)
                MessageBox.Show("Please select customer to update.");
            else
            {
                frmCustomer frmCustomer = new frmCustomer();
                frmCustomer._dtoCustomerDetail= dtoCustomerDetail;
                frmCustomer._IsUpdate = true;
                this.Hide();
                frmCustomer.ShowDialog();
                this.Visible = true;
                fillDataGrid();
                txtCustomername.Text = "";
                txtCustomername.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtoCustomerDetail.CustomerID == 0)
                MessageBox.Show("No record selected to delete from table.");
            else 
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bllCustomer.Delete(dtoCustomerDetail))
                    {
                        MessageBox.Show("Customer was deleted.");
                        fillDataGrid();
                        txtCustomername.Text = "";
                        txtCustomername.Clear();
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
