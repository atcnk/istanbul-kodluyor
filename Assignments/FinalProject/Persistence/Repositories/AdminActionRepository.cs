using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class AdminActionRepository : EfRepositoryBase<AdminAction, HospitalAppointmentSystemDbContext>, IAdminActionRepository
    {
        public AdminActionRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
