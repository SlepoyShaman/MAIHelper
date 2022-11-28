using Microsoft.EntityFrameworkCore;
using maihelper.Models.DataModels;
using maihelper.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace maihelper.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Work> Works { get; set; }

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}