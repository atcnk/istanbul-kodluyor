﻿using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IAdminActionRepository : IRepository<AdminAction>, IAsyncRepository<AdminAction>
    {
    }
}
