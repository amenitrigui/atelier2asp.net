using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace atelier2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options): base(options)
            {

            }
    public DbSet <Product> Products {  get; set; }

    }
}
