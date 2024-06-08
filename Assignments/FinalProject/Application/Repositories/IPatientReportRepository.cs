using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IPatientReportRepository : IRepository<PatientReport>, IAsyncRepository<PatientReport>
    {
    }
}
