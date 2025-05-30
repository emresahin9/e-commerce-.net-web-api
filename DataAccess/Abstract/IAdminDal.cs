﻿using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAdminDal : IEntityRepository<Admin>
    {
        List<OperationClaim> GetClaims(Admin admin);
    }
}
