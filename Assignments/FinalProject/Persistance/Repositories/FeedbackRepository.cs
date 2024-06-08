using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class FeedbackRepository : EfRepositoryBase<Feedback, HospitalAppointmentSystemDbContext>, IFeedbackRepository
    {
        public FeedbackRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
