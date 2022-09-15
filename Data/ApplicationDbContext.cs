using Microsoft.EntityFrameworkCore;
using maihelper.Models;

namespace maihelper.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<LaboratoryWork> laboratoryWorks { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
      
    }
}
