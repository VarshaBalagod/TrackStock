using StockTraker.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockTraker.DAL.DAO
{
    public class SalesDAO : StockContext, IDAO<TABLE_SALES, SalesDetailDTO>
    {
        public bool Delete(TABLE_SALES entity)
        {
            try
            {
                if (entity.SalesID != 0)
                {
                    TABLE_SALES tableSales = db.TABLE_SALES.First(x => x.SalesID == entity.SalesID);
                    tableSales.IsDeleted = true;
                    tableSales.DateDeleted = DateTime.Today;
                    db.SaveChanges();
                }
                else if(entity.ProductID != 0) 
                {
                    List<TABLE_SALES> list = db.TABLE_SALES.Where(x=>x.ProductID == entity.ProductID).ToList();
                    foreach(var item in list)
                    {
                        item.IsDeleted = true;
                        item.DateDeleted = DateTime.Today;
                    }
                    db.SaveChanges();
                }
                else if (entity.CustomerID != 0)
                {
                    List<TABLE_SALES> list = db.TABLE_SALES.Where(x => x.CustomerID == entity.CustomerID).ToList();
                    foreach (var item in list)
                    {
                        item.IsDeleted = true;
                        item.DateDeleted = DateTime.Today;
                    }
                    db.SaveChanges();
                }
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
                TABLE_SALES tableSales = db.TABLE_SALES.First(x => x.SalesID == ID);
                tableSales.IsDeleted = false;
                tableSales.DateDeleted = Convert.ToDateTime(null);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(TABLE_SALES entity)
        {
            try 
            {
                db.TABLE_SALES.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex) 
            {
                throw ex;
            }

        }

        public List<SalesDetailDTO> Select()
        {
            try
            {
                List<SalesDetailDTO> dtoSalesDetail = new List<SalesDetailDTO>();
                var list = (from s in db.TABLE_SALES where (s.IsDeleted == false)
                            join p in db.TABLE_PRODUCT on s.ProductID equals p.ProductID
                            join ct in db.TABLE_CATEGORY on s.CategoryID equals ct.CategoryID
                            join c in db.TABLE_CUSTOMER on s.CustomerID equals c.CustomerID
                            select new
                            {

                                ProductID = s.ProductID,
                                ProductName = p.ProductName,
                                Price = p.Price,
                                StockAmount = p.StockAmount,

                                CustomerID = s.CustomerID,
                                CustomerName = c.CustomerName,

                                CategoryID = p.CategoryID,
                                CategoryName = ct.CategoryName,

                                SalesID = s.SalesID,
                                SalesAmount = s.ProductSalesAmount,
                                SalesDate = s.DateSales
                            }).OrderBy(x => x.SalesDate).ToList();

                foreach(var item in list)
                {
                    SalesDetailDTO dtosales = new SalesDetailDTO();
                    dtosales.ProductID = item.ProductID;
                    dtosales.ProductName = item.ProductName;
                    dtosales.Price = item.Price;
                    dtosales.StockAmount = item.StockAmount;
                    dtosales.CustomerID = item.CustomerID;
                    dtosales.CustomerName = item.CustomerName;
                    dtosales.CategoryID = item.CategoryID;
                    dtosales.CategoryName = item.CategoryName;
                    dtosales.SalesID = item.SalesID;
                    dtosales.SalesAmount = item.SalesAmount;
                    dtosales.SalesDate = item.SalesDate;

                    dtoSalesDetail.Add(dtosales);
                }

                return dtoSalesDetail;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public List<SalesDetailDTO> Select(bool IsDeleted)
        {
            try
            {
                List<SalesDetailDTO> dtoSalesDetail = new List<SalesDetailDTO>();
                var list = (from s in db.TABLE_SALES
                            where (s.IsDeleted == IsDeleted)
                            join p in db.TABLE_PRODUCT on s.ProductID equals p.ProductID
                            join ct in db.TABLE_CATEGORY on s.CategoryID equals ct.CategoryID
                            join c in db.TABLE_CUSTOMER on s.CustomerID equals c.CustomerID
                            select new
                            {

                                ProductID = s.ProductID,
                                ProductName = p.ProductName,
                                Price = p.Price,
                                StockAmount = p.StockAmount,

                                CustomerID = s.CustomerID,
                                CustomerName = c.CustomerName,

                                CategoryID = p.CategoryID,
                                CategoryName = ct.CategoryName,

                                SalesID = s.SalesID,
                                SalesAmount = s.ProductSalesAmount,
                                SalesDate = s.DateSales,

                                isCatDeleted= ct.IsDeleted,
                                isProdDeleted= p.IsDeleted,
                                isCustDeleted= c.IsDeleted
                            }).OrderBy(x => x.SalesDate).ToList();

                foreach (var item in list)
                {
                    SalesDetailDTO dtosales = new SalesDetailDTO();
                    dtosales.ProductID = item.ProductID;
                    dtosales.ProductName = item.ProductName;
                    dtosales.Price = item.Price;
                    dtosales.StockAmount = item.StockAmount;
                    dtosales.CustomerID = item.CustomerID;
                    dtosales.CustomerName = item.CustomerName;
                    dtosales.CategoryID = item.CategoryID;
                    dtosales.CategoryName = item.CategoryName;
                    dtosales.SalesID = item.SalesID;
                    dtosales.SalesAmount = item.SalesAmount;
                    dtosales.SalesDate = item.SalesDate;
                    dtosales.IsCategoryDeleted = item.isCatDeleted;
                    dtosales.IsProductDeleted = item.isProdDeleted;
                    dtosales.IsCustomerDeleted = item.isCustDeleted;
                    dtoSalesDetail.Add(dtosales);
                }

                return dtoSalesDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(TABLE_SALES entity)
        {
            try 
            {
                TABLE_SALES tableSales = db.TABLE_SALES.First(x => x.SalesID == entity.SalesID);
                tableSales.ProductSalesAmount = entity.ProductSalesAmount;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
