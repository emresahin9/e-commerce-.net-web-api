using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.EfDals
{
    public class EfProductImageDal : EfEntityRepositoryBase<ProductImage, ECommerceContext>, IProductImageDal
    {
    }
}
