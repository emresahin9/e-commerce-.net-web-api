using Core.Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdminService
    {
        List<OperationClaim> GetClaims(Admin admin);
        Admin GetByMail(string email);
    }
}
