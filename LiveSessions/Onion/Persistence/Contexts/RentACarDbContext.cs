/* DB'yi burada bagliyoruz.
 * Brand entity'si icin DbSet'i de olusturduk.
 * Contexts klasorunun olmasi ileride daha fazla DB ile
 * calisabilme ihtimalimizden dolayi.
 */

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class RentACarDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Tobeto4A.Onion; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
