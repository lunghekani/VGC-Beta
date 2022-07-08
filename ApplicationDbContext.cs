using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VGC.Models;

namespace VGC
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Topics> Topics { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Marks> Marks { get; set; }
        public DbSet<Assessment> CreateAssessment { get; set; }
        


    }
}
