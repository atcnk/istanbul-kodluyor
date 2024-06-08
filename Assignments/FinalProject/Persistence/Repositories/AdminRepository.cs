using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class AdminRepository : EfRepositoryBase<Admin, HospitalAppointmentSystemDbContext>, IAdminRepository
    {
        public AdminRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}