using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IAppointmentRepository : IRepository<Appointment>, IAsyncRepository<Appointment>
    {
    }
}
