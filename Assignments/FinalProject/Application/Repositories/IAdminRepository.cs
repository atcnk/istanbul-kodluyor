using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IAdminRepository : IRepository<Admin>, IAsyncRepository<Admin>
    {
    }
}
