using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Categories
    {
        public static Models.Categories ToModel(Data.Category category )
        {
            return new Models.Categories()
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                Description = category.Description,
                CreationDate = category.CreationDate,
                ModificationDate = category.ModificationDate,
                EndDate = category.EndDate
            };
        }

        public static List<Models.Categories> ToModelList(List<Data.Category> categories)
        {
            var categoryList = new List<Models.Categories>();
            categoryList = categories.Select(category => new Models.Categories
            {
                CategoryId = category.CategoryId,
                Name = category.Name,
                Description = category.Description,
                CreationDate = category.CreationDate,
                ModificationDate = category.ModificationDate,
                EndDate = category.EndDate
            }).ToList();

            return categoryList;
        }

        public static List<Models.Categories> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var categories = db.Fetch<Data.Category>("WHERE EndDate IS NULL ORDER BY CategoryId Desc");
                if (categories == null) return null;
                if (categories.Count == 0) return null;

                return ToModelList(categories);
            }
        }

        public static Models.Categories GetByCategoryId(int categoryId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var category = db.FirstOrDefault<Data.Category>("WHERE CategoryId = @0", categoryId);
                if (category == null) return null;

                return ToModel(category);
            }
        }

        public static List<Models.Categories> GetByCategoryIdList(List<int> categoryIdList)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbCategories = db.Fetch<Data.Category>("WHERE CategoryId IN (@0)", categoryIdList);
                if (dbCategories == null) return null;
                if (dbCategories.Count == 0) return null;

                return ToModelList(dbCategories);
            }
        }
        public static Models.Categories GetByCategoryName(string categoryName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbCategories = db.FirstOrDefault<Data.Category>("WHERE Name = @0 AND EndDate IS NULL", categoryName);
                if (dbCategories == null) return null;

                return ToModel(dbCategories);
            }
        }

        public static List<Models.Categories> Search(string searchString,bool searchOnName=false)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbCategories = !searchOnName ? db.Fetch<Data.Category>("WHERE (Name LIKE @0 OR Description LIKE @0) AND EndDate IS NULL ORDER BY CategoryId Desc", "%"+searchString+ "%"): db.Fetch<Data.Category>("WHERE Name LIKE @0 AND EndDate IS NULL ORDER BY CategoryId Desc", "%" + searchString + "%");
                if (dbCategories == null) return null;
                if (dbCategories.Count == 0) return null;

                return ToModelList(dbCategories);
            }
        }

        public static bool AddCategory(Models.Categories category)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbCategory = new Data.Category()
                    {
                        Name = category.Name,
                        Description = category.Description,
                        CreationDate = DateTime.Now
                    };
                    db.Save(dbCategory);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateCategory(Models.Categories category)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbCategory = db.FirstOrDefault<Data.Category>("WHERE CategoryId = @0 AND EndDate IS NULL", category.CategoryId);
                    if (dbCategory == null) return false;

                    dbCategory.Name = category.Name;
                    dbCategory.Description = category.Description;
                    dbCategory.ModificationDate = DateTime.Now;
                    db.Update(dbCategory);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteCategory(int categoryId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbCategory = db.FirstOrDefault<Data.Category>("WHERE CategoryId = @0", categoryId);
                    if (dbCategory != null)
                    {
                        dbCategory.EndDate = DateTime.Now;
                        db.Update(dbCategory);
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Models.Categories CheckcategorynameExist(string categoryName, int? categoryId = null)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var category = categoryId == null ? db.FirstOrDefault<Data.Category>("WHERE Name = @0 AND EndDate IS NULL", categoryName) : db.FirstOrDefault<Data.Category>("Where Name = @0 AND EndDate IS NULL AND CategoryId !=@1", categoryName, categoryId);
                if (category == null) return null;

                return ToModel(category);
            }
        }
    }
}
