/* repo haline getirmek istedigimiz bir class'i EfRepository'den alip
 * icerisine hangi entity icin hangi context'i kullanarak islem yapacagimi veriyorum.
 */

using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, RentACarDbContext>, IBrandRepository
    {
        public BrandRepository(RentACarDbContext context) : base(context)
        {
        }
    }
}
