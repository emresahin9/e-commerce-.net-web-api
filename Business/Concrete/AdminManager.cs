using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetByMail(string email)
        {
            return _adminDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(Admin admin)
        {
            return _adminDal.GetClaims(admin);
        }
    }
}
