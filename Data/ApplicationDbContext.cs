using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using maihelper.Models.DataModels;

namespace maihelper.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Создание баз данных с каждым отношением
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Work> Works { get; set; }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
    }
}