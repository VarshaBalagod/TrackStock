using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTraker.DAL.DTO;
using StockTraker.DAL.DAO;
using StockTraker.DAL;

namespace StockTraker.BLL
{
    public class ProductBLL : IBLL<ProductDetailDTO, ProductDTO>
    {
        CategoryDAO daoCategory = new CategoryDAO();
        ProductDAO daoProduct = new ProductDAO();
        SalesDAO daoSales = new SalesDAO();

        public bool Delete(ProductDetailDTO entity)
        {
           TABLE_PRODUCT tableProduct = new TABLE_PRODUCT();
            tableProduct.ProductID = entity.ProductID;
            daoProduct.Delete(tableProduct);

            TABLE_SALES tableSales= new TABLE_SALES();
            tableSales.ProductID = entity.ProductID;
            daoSales.Delete(tableSales);
            return true;
        }

        public bool GetBack(ProductDetailDTO entity)
        {
            return daoProduct.GetBack(entity.ProductID);
        }

        public bool Insert(ProductDetailDTO entity)
        {
            TABLE_PRODUCT tableProduct = new TABLE_PRODUCT();
            tableProduct.ProductName = entity.ProductName;
            tableProduct.CategoryID = entity.CategoryID;
            tableProduct.Price = entity.ProductPrice;
            return daoProduct.Insert(tableProduct);
        }

        public ProductDTO Select()
        {
            ProductDTO dtoProduct= new ProductDTO();
            dtoProduct.Categories = daoCategory.Select();
            dtoProduct.Products= daoProduct.Select();
            return dtoProduct;
        }

        public bool Update(ProductDetailDTO entity)
        {
            TABLE_PRODUCT tableProduct= new TABLE_PRODUCT();
            tableProduct.ProductID = entity.ProductID;
            tableProduct.ProductName= entity.ProductName;
            tableProduct.Price = entity.ProductPrice;
            tableProduct.StockAmount = entity.StockAmount;
            tableProduct.CategoryID= entity.CategoryID;
            return daoProduct.Update(tableProduct);
        }
    }
}
