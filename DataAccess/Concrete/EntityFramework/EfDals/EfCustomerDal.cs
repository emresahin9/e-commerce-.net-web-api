using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.EfDals
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ECommerceContext>, ICustomerDal
    {
    }
}
