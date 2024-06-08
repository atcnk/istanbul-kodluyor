using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class AppointmentRepository : EfRepositoryBase<Appointment, HospitalAppointmentSystemDbContext>, IAppointmentRepository
    {
        public AppointmentRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
