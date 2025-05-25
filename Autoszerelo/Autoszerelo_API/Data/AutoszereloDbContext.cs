using Autoszerelo_Shared; //ugyfel es munka
using Microsoft.EntityFrameworkCore;

namespace Autoszerelo_API.Data
{
    public class AutoszereloDbContext : DbContext //inheritance
    {
        public AutoszereloDbContext(DbContextOptions<AutoszereloDbContext> options) { 
        
        }

        public DbSet<Ugyfel> Ugyfelek { get; set; }
        public DbSet<Munka> Munkak { get; set; }
    }
}
