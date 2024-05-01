/* application katmaninin persistence katmanina bagimliligini minimize etmek
 * amaciyla soyutlamayi bu katman uzerinde yaptik.
 * artik soyle bir interface istiyorum, bu interface'i entegre eden her katmanla calisirim.
 * sarmallamis oldu application katmani persistence'i. n-katmanlidan farki bu, soyutlamanin yeri.
 * application'in katmaninin persistence'a bagimli olmamasi saglayip gereksinimlerini belirlemis olduk.
 */

using Core.DataAccess;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IBrandRepository : IRepository<Brand>, IAsyncRepository<Brand>
    {

    }
}
