using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IDoctorRepository : IRepository<Doctor>, IAsyncRepository<Doctor>
    {
    }
}
