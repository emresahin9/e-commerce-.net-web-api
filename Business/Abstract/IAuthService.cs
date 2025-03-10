using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Admin> LoginAdmin(LoginDto loginDto);
        IDataResult<AccessToken> CreateAccessTokenForAdmin(Admin admin);
    }
}
