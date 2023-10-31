using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTraker.DAL.DTO;

namespace StockTraker.DAL.DAO
{
    public class CategoryDAO : StockContext, IDAO<TABLE_CATEGORY, CategoryDetailDTO>
    {
        public bool Delete(TABLE_CATEGORY entity)
        {
            try 
            {
                TABLE_CATEGORY tableCategory = db.TABLE_CATEGORY.First(x => x.CategoryID == entity.CategoryID);
                tableCategory.IsDeleted = true;
                tableCategory.DateDeleted = DateTime.Today;
                db.SaveChanges();
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
                TABLE_CATEGORY tableCategory= db.TABLE_CATEGORY.First(x=>x.CategoryID == ID);
                tableCategory.IsDeleted = false;
                tableCategory.DateDeleted = Convert.ToDateTime(null);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }

        public bool Insert(TABLE_CATEGORY entity)
        {
            try
            {
                db.TABLE_CATEGORY.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryDetailDTO> Select()
        {
            try 
            {
               List<CategoryDetailDTO> dtoCategoriesDetail= new List<CategoryDetailDTO>();
                var list = db.TABLE_CATEGORY.Where(x => x.IsDeleted == false);
                foreach (var item in list)
                {
                    CategoryDetailDTO categoryDetail = new CategoryDetailDTO();
                    categoryDetail.CategoryId = item.CategoryID;
                    categoryDetail.CategoryName = item.CategoryName;
                    dtoCategoriesDetail.Add(categoryDetail);                    
                }
                return dtoCategoriesDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CategoryDetailDTO> Select(bool IsDeleted)
        {
            try
            {
                List<CategoryDetailDTO> dtoCategoriesDetail = new List<CategoryDetailDTO>();
                var list = db.TABLE_CATEGORY.Where(x => x.IsDeleted == IsDeleted).ToList();
                foreach (var item in list)
                {
                    CategoryDetailDTO categoryDetail = new CategoryDetailDTO();
                    categoryDetail.CategoryId = item.CategoryID;
                    categoryDetail.CategoryName = item.CategoryName;
                    dtoCategoriesDetail.Add(categoryDetail);
                }
                return dtoCategoriesDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(TABLE_CATEGORY entity)
        {
            try
            {
                TABLE_CATEGORY tableCategory = db.TABLE_CATEGORY.First(x => x.CategoryID == entity.CategoryID);
                tableCategory.CategoryName = entity.CategoryName;
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
