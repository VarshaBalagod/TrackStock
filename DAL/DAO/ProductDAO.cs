using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTraker.DAL;
using StockTraker.DAL.DTO;

namespace StockTraker.DAL.DAO
{
    public class ProductDAO : StockContext, IDAO<TABLE_PRODUCT, ProductDetailDTO>
    {
        public bool Delete(TABLE_PRODUCT entity)
        {
            try
            {
                if (entity.ProductID != 0)
                {
                    TABLE_PRODUCT tableProdutct = db.TABLE_PRODUCT.First(x => x.ProductID == entity.ProductID);
                    tableProdutct.IsDeleted = true;
                    tableProdutct.DateDeleted = DateTime.Today;
                    db.SaveChanges();
                }
                else if(entity.CategoryID != 0) 
                {
                    List<TABLE_PRODUCT> tableProduct = db.TABLE_PRODUCT.Where(x => x.CategoryID == entity.CategoryID).ToList();
                    foreach (var product in tableProduct) 
                    {
                        product.IsDeleted = true;
                        product.DateDeleted = DateTime.Today;

                        List<TABLE_SALES> tableSale = db.TABLE_SALES.Where(x => x.ProductID == product.ProductID).ToList();
                        foreach(var sales in tableSale)
                        {
                            sales.IsDeleted = true;
                            sales.DateDeleted = DateTime.Today;
                        }
                    }                   
                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            try
            {
                TABLE_PRODUCT tableProduct = db.TABLE_PRODUCT.First(x => x.ProductID == ID);
                tableProduct.IsDeleted = false;
                tableProduct.DateDeleted = Convert.ToDateTime(null);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Insert(TABLE_PRODUCT entity)
        {
            try
            {
                db.TABLE_PRODUCT.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public List<ProductDetailDTO> Select()
        {
            try
            {
                List<ProductDetailDTO> products = new List<ProductDetailDTO>();
                var list = (from p in db.TABLE_PRODUCT where(p.IsDeleted == false)
                            join c in db.TABLE_CATEGORY on p.CategoryID equals c.CategoryID
                            select new
                            {
                                productName = p.ProductName,
                                productID = p.ProductID,
                                productPrice = p.Price,
                                productStockAmount = p.StockAmount,
                                categoryID = c.CategoryID,
                                categoryName = c.CategoryName
                            }).OrderBy(x => x.productName).ToList();

                foreach (var item in list)
                {
                    ProductDetailDTO dtoProductDetail= new ProductDetailDTO();
                    dtoProductDetail.ProductName = item.productName;
                    dtoProductDetail.ProductPrice = item.productPrice;
                    dtoProductDetail.StockAmount = item.productStockAmount;
                    dtoProductDetail.ProductID = item.productID;
                    dtoProductDetail.CategoryID = item.categoryID;
                    dtoProductDetail.CategoryName = item.categoryName;
                    products.Add(dtoProductDetail);
                }
                return products;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public List<ProductDetailDTO> Select(bool IsDeleted)
        {
            try
            {
                List<ProductDetailDTO> products = new List<ProductDetailDTO>();
                var list = (from p in db.TABLE_PRODUCT
                            where (p.IsDeleted == IsDeleted)
                            join c in db.TABLE_CATEGORY on p.CategoryID equals c.CategoryID
                            select new
                            {
                                productName = p.ProductName,
                                productID = p.ProductID,
                                productPrice = p.Price,
                                productStockAmount = p.StockAmount,
                                categoryID = c.CategoryID,
                                categoryName = c.CategoryName,
                                isCatDeleted= c.IsDeleted
                            }).OrderBy(x => x.productName).ToList();

                foreach (var item in list)
                {
                    ProductDetailDTO dtoProductDetail = new ProductDetailDTO();
                    dtoProductDetail.ProductName = item.productName;
                    dtoProductDetail.ProductPrice = item.productPrice;
                    dtoProductDetail.StockAmount = item.productStockAmount;
                    dtoProductDetail.ProductID = item.productID;
                    dtoProductDetail.CategoryID = item.categoryID;
                    dtoProductDetail.CategoryName = item.categoryName;
                    dtoProductDetail.IsCategoryDeleted = item.isCatDeleted;
                    products.Add(dtoProductDetail);
                }
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(TABLE_PRODUCT entity)
        {
            try 
            {
                TABLE_PRODUCT tableProduct = db.TABLE_PRODUCT.First(x => x.ProductID == entity.ProductID);
                if(entity.CategoryID == 0)
                {
                    tableProduct.StockAmount = entity.StockAmount;                  
                }
                else
                {
                    tableProduct.ProductName = entity.ProductName;
                    tableProduct.CategoryID = entity.CategoryID;
                    tableProduct.Price = entity.Price;
                }
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
