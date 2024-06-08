using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class NotificationRepository : EfRepositoryBase<Notification, HospitalAppointmentSystemDbContext>, INotificationRepository
    {
        public NotificationRepository(HospitalAppointmentSystemDbContext context) : base(context)
        {
        }
    }
}
