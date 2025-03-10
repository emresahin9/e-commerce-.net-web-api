using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.EfDals
{
    public class EfDistrictDal : EfEntityRepositoryBase<District, ECommerceContext>, IDistrictDal
    {
    }
}
