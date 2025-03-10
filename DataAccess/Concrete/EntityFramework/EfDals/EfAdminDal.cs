using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework.EfDals
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, ECommerceContext>, IAdminDal
    {
        public List<OperationClaim> GetClaims(Admin admin)
        {
            using (var context = new ECommerceContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.AdminOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.AdminId == admin.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }
    }
}
