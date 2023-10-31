using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTraker.DAL.DTO;

namespace StockTraker.DAL.DAO
{
    public class CustomerDAO : StockContext, IDAO<TABLE_CUSTOMER, CustomerDetailDTO>
    {
        public bool Delete(TABLE_CUSTOMER entity)
        {
            try
            {
                TABLE_CUSTOMER tableCustomer = db.TABLE_CUSTOMER.First(x => x.CustomerID == entity.CustomerID);
                tableCustomer.IsDeleted = true;
                tableCustomer.DateDeleted = DateTime.Today;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            try
            {
                TABLE_CUSTOMER tableCustomer = db.TABLE_CUSTOMER.First(x => x.CustomerID == ID);
                tableCustomer.IsDeleted = false;
                tableCustomer.DateDeleted = Convert.ToDateTime(null);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public bool Insert(TABLE_CUSTOMER entity)
        {
            try 
            {
                db.TABLE_CUSTOMER.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select()
        {
            try
            {
                List<CustomerDetailDTO> dtoCustomerDetail = new List<CustomerDetailDTO>();
                var list = db.TABLE_CUSTOMER.Where(x => x.IsDeleted == false).ToList();
                foreach (var item in list)
                {
                    CustomerDetailDTO cutomerDetail = new CustomerDetailDTO();
                    cutomerDetail.CustomerID = item.CustomerID;
                    cutomerDetail.CustomerName = item.CustomerName;
                    dtoCustomerDetail.Add(cutomerDetail);
                }
                return dtoCustomerDetail;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select(bool IsDeleted)
        {
            try
            {
                List<CustomerDetailDTO> dtoCustomerDetail = new List<CustomerDetailDTO>();
                var list = db.TABLE_CUSTOMER.Where(x => x.IsDeleted == IsDeleted).ToList();
                foreach (var item in list)
                {
                    CustomerDetailDTO cutomerDetail = new CustomerDetailDTO();
                    cutomerDetail.CustomerID = item.CustomerID;
                    cutomerDetail.CustomerName = item.CustomerName;
                    dtoCustomerDetail.Add(cutomerDetail);
                }
                return dtoCustomerDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(TABLE_CUSTOMER entity)
        {
            try
            {
                TABLE_CUSTOMER tableCustomer = db.TABLE_CUSTOMER.First(x=>x.CustomerID == entity.CustomerID);
                tableCustomer.CustomerName = entity.CustomerName;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex) 
            {
                throw ex;
            }

        }
    }
}
