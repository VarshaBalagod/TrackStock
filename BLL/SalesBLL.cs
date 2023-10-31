using StockTraker.DAL;
using StockTraker.DAL.DAO;
using StockTraker.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTraker.BLL
{
    public class SalesBLL : IBLL<SalesDetailDTO, SalesDTO>
    {
        SalesDAO daoSales = new SalesDAO();
        ProductDAO daoProduct = new ProductDAO();
        CustomerDAO daoCustomer = new CustomerDAO();
        CategoryDAO daoCategory = new CategoryDAO();

        public bool Delete(SalesDetailDTO entity)
        {
            TABLE_SALES tableSales = new TABLE_SALES();
            tableSales.SalesID = entity.SalesID;
            daoSales.Delete(tableSales);

            TABLE_PRODUCT tableProduct = new TABLE_PRODUCT();
            tableProduct.ProductID = entity.ProductID;
            tableProduct.StockAmount = entity.StockAmount + entity.SalesAmount;
            daoProduct.Update(tableProduct);

            return true;
        }

        public bool GetBack(SalesDetailDTO entity)
        {
            daoSales.GetBack(entity.SalesID);

            TABLE_PRODUCT product = new TABLE_PRODUCT();
            product.ProductID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            product.StockAmount = temp;
            daoProduct.Update(product);

            return true;
        }

        public bool Insert(SalesDetailDTO entity)
        {
            TABLE_SALES tableSales= new TABLE_SALES();
            tableSales.CategoryID = entity.CategoryID;
            tableSales.ProductID = entity.ProductID;
            tableSales.CustomerID = entity.CustomerID;
            tableSales.ProductSalesAmount = entity.SalesAmount;
            tableSales.ProductSalesPrice = entity.Price;
            tableSales.DateSales = entity.SalesDate;
            daoSales.Insert(tableSales);

            TABLE_PRODUCT tableProduct= new TABLE_PRODUCT();
            tableProduct.ProductID = entity.ProductID;
            int totalStock = entity.StockAmount - entity.SalesAmount;
            tableProduct.StockAmount = totalStock;
            daoProduct.Update(tableProduct);

            return true;
        }

        public SalesDTO Select()
        {
            SalesDTO dtoSales = new SalesDTO();
            dtoSales.Products = daoProduct.Select();
            dtoSales.Customers = daoCustomer.Select();
            dtoSales.Categories = daoCategory.Select();
            dtoSales.Sales = daoSales.Select();
            return dtoSales;
        }

        public SalesDTO Select(bool IsDeleted)
        {
            SalesDTO dtoSales = new SalesDTO();
            dtoSales.Products = daoProduct.Select(IsDeleted);
            dtoSales.Customers = daoCustomer.Select(IsDeleted);
            dtoSales.Categories = daoCategory.Select(IsDeleted);
            dtoSales.Sales = daoSales.Select(IsDeleted);
            return dtoSales;
        }

        public bool Update(SalesDetailDTO entity)
        {
            TABLE_SALES tableSale = new TABLE_SALES();
            tableSale.SalesID = entity.SalesID;
            tableSale.ProductSalesAmount = entity.SalesAmount;
            daoSales.Update(tableSale);

            TABLE_PRODUCT tableProduct = new TABLE_PRODUCT();
            tableProduct.ProductID= entity.ProductID;
            tableProduct.StockAmount= entity.StockAmount;
            daoProduct.Update(tableProduct);

            return true;
        }
    }
}
