using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class PatientRepository : EfRepositoryBase<Patient, HospitalAppointmentSystemDbContext>, IPatientRepository
    {
        public PatientRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
