/* her katman servislerini kendisi eklemeli.
 * bunu yaparken extension metot kullaniyoruz.
 * bir hazir sistemin icerisine kod eklemek gibi o sistemi genisletmek. 
 */

using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            /* migration yapmak icin oncelikle DbContext sistem tarafinda taninmali.
            * artik sistem ayaga kaldirilirken bu dbcontext'im taninacak.
            */

            services.AddDbContext<RentACarDbContext>();

            // ne zaman IBrandRepository istenirse BrandRepository dondur demis oluyoruz.
          
            services.AddScoped<IBrandRepository, BrandRepository>();

            return services;
        }
    }
}
