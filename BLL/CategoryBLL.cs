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
    public class CategoryBLL : IBLL<CategoryDetailDTO, CategoryDTO>
    {
        CategoryDAO daoCategory = new CategoryDAO();
        ProductDAO daoProduct = new ProductDAO();

        public bool Delete(CategoryDetailDTO entity)
        {
            TABLE_CATEGORY tableCategory= new TABLE_CATEGORY();
            tableCategory.CategoryID = entity.CategoryId;
            daoCategory.Delete(tableCategory);

            TABLE_PRODUCT tableProduct= new TABLE_PRODUCT();
            tableProduct.CategoryID = entity.CategoryId;
            daoProduct.Delete(tableProduct);

            return true;
        }

        public bool GetBack(CategoryDetailDTO entity)
        {            
            return daoCategory.GetBack(entity.CategoryId); 
        }

        public bool Insert(CategoryDetailDTO entity)
        {
            TABLE_CATEGORY tblCategory = new TABLE_CATEGORY();
            tblCategory.CategoryName = entity.CategoryName;
            return daoCategory.Insert(tblCategory);
        }

        public CategoryDTO Select()
        {
            CategoryDTO dtoCategory = new CategoryDTO();
            dtoCategory.Categories = daoCategory.Select();
            return dtoCategory;
        }

        public bool Update(CategoryDetailDTO entity)
        {
            TABLE_CATEGORY tableCategory = new TABLE_CATEGORY();
            tableCategory.CategoryName = entity.CategoryName;
            tableCategory.CategoryID = entity.CategoryId;
            return daoCategory.Update(tableCategory);
        }
    }
}
