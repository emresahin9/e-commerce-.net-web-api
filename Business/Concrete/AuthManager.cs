using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IAdminService _adminService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IAdminService adminService, ITokenHelper tokenHelper)
        {
            _adminService = adminService;
            _tokenHelper = tokenHelper;
        }
        public IDataResult<AccessToken> CreateAccessTokenForAdmin(Admin admin)
        {
            var claims = _adminService.GetClaims(admin);
            var accessoken = _tokenHelper.CreateToken(new User{ Id = admin.Id, FirstName = admin.FirstName, LastName = admin.LastName, Email = admin.Email }, claims);
            return new SuccessDataResult<AccessToken>(accessoken, Messages.AccessTokenCreated);
        }

        public IDataResult<Admin> LoginAdmin(LoginDto loginDto)
        {
            var userToCheck = _adminService.GetByMail(loginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<Admin>(Messages.UserNotFound);
            }

            if(!HashingHelper.VerifyPasswordHash(loginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Admin>(Messages.PasswordError);
            }

            return new SuccessDataResult<Admin>(userToCheck, Messages.SuccessfulLogin);
        }
    }
}
