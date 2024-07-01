using Microsoft.EntityFrameworkCore;
using VLMS.Models;

namespace VLMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
