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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        #region Declarations
        CustomerBLL bllCustomer = new CustomerBLL();
        public CustomerDetailDTO _dtoCustomerDetail = new CustomerDetailDTO();
        public bool _IsUpdate = false;
        bool validData = false;
        #endregion

        #region Functions
        void clearData()
        {
            txtCustomername.Text = "";
            txtCustomername.Clear();
            validData = false;
        }

        void validationComponant()
        {
            if (txtCustomername.Text.Trim() == "")
                MessageBox.Show("Please enter customer name.");
            else
                validData = true;
        }
        #endregion

        #region Form Load
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            if (_IsUpdate)
            {
                txtCustomername.Text = _dtoCustomerDetail.CustomerName;
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
                if (!_IsUpdate)
                {
                    CustomerDetailDTO dtoCustomerDetail = new CustomerDetailDTO();
                    dtoCustomerDetail.CustomerName = txtCustomername.Text;
                    if (bllCustomer.Insert(dtoCustomerDetail))
                    {
                        MessageBox.Show("Customer was added.");
                        clearData();
                    }
                }
                else if (_IsUpdate)
                {
                    if (_dtoCustomerDetail.CustomerName == txtCustomername.Text)
                        MessageBox.Show("There is no change in record.");
                    else
                    {
                        _dtoCustomerDetail.CustomerName=txtCustomername.Text;
                        if (bllCustomer.Update(_dtoCustomerDetail))
                        {
                            MessageBox.Show("Customer is updated.");
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
