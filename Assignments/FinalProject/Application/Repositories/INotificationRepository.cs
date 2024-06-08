using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
    public interface INotificationRepository : IRepository<Notification>, IAsyncRepository<Notification>
    {
    }
}
