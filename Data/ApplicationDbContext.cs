using Microsoft.EntityFrameworkCore;
using maihelper.Models;

namespace maihelper.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Создание баз данных с каждым отношением
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<LaboratoryWork> LaboratoryWorks { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Note> Notes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
      
    }
}
