using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.EfDals
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ECommerceContext>, ICategoryDal
    {
        public List<CategoryForOption> GetCategoriesForOptions()
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var result = from c in context.Categories
                             select new CategoryForOption
                             {
                                 Id = c.Id,
                                 Name = c.Name
                             };
                return result.ToList();
            }
        }
    }
}
