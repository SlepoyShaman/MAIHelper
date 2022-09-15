using Microsoft.EntityFrameworkCore;
using maihelper.Models;

namespace maihelper.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
      
    }
}
