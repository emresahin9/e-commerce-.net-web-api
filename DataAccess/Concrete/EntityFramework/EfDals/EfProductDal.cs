using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.EfDals
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
        public List<ProductDetailDto> GetAllProductsDetails(int? categoryId)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             where categoryId == null || p.CategoryId == categoryId
                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 CategoryId = c.Id,
                                 CategoryName = c.Name
                             };
                return result.ToList();
            }
        }
        public ProductDetailDto GetProductDetailById(int productId)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             where p.Id == productId
                             select new ProductDetailDto
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 CategoryId = c.Id,
                                 CategoryName = c.Name
                             };
                return result.FirstOrDefault();
            }
        }
    }
}
