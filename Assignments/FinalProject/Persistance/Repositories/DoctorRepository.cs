using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class DoctorRepository : EfRepositoryBase<Doctor, HospitalAppointmentSystemDbContext>, IDoctorRepository
    {
        public DoctorRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
