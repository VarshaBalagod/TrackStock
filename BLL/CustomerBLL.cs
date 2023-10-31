using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTraker.DAL;
using StockTraker.DAL.DAO;
using StockTraker.DAL.DTO;

namespace StockTraker.BLL
{
    public class CustomerBLL : IBLL<CustomerDetailDTO, CustomerDTO>
    {
        CustomerDAO daoCustomer = new CustomerDAO();
        SalesDAO daoSales=new SalesDAO();   

        public bool Delete(CustomerDetailDTO entity)
        {
            TABLE_CUSTOMER tableCustomer = new TABLE_CUSTOMER();
            tableCustomer.CustomerID = entity.CustomerID;
            daoCustomer.Delete(tableCustomer);

            TABLE_SALES tableSales = new TABLE_SALES();
            tableSales.CustomerID = entity.CustomerID;
            daoSales.Delete(tableSales);
            return true;
        }

        public bool GetBack(CustomerDetailDTO entity)
        {
            return daoCustomer.GetBack(entity.CustomerID);
        }

        public bool Insert(CustomerDetailDTO entity)
        {
            TABLE_CUSTOMER tableCustomer = new TABLE_CUSTOMER();
            tableCustomer.CustomerName = entity.CustomerName;
            return daoCustomer.Insert(tableCustomer);
        }

        public CustomerDTO Select()
        {
            CustomerDTO dtoCustomer= new CustomerDTO();
            dtoCustomer.Customers = daoCustomer.Select();
            return dtoCustomer;
        }

        public bool Update(CustomerDetailDTO entity)
        {
            TABLE_CUSTOMER tableCustomer= new TABLE_CUSTOMER();
            tableCustomer.CustomerID=entity.CustomerID;
            tableCustomer.CustomerName=entity.CustomerName;
            return daoCustomer.Update(tableCustomer);        
        }
    }
}
