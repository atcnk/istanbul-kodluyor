using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class UserRepository : EfRepositoryBase<User, HospitalAppointmentSystemDbContext>, IUserRepository
    {
        public UserRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
