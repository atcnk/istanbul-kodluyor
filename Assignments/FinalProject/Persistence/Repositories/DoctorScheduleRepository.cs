using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class DoctorScheduleRepository : EfRepositoryBase<DoctorSchedule, HospitalAppointmentSystemDbContext>, IDoctorScheduleRepository
    {
        public DoctorScheduleRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
