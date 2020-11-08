using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice
{
    public class EFDBContext : DbContext
    {
        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}