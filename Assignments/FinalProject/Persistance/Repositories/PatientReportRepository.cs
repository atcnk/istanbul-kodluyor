using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class PatientReportRepository : EfRepositoryBase<PatientReport, HospitalAppointmentSystemDbContext>, IPatientReportRepository
    {
        public PatientReportRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
