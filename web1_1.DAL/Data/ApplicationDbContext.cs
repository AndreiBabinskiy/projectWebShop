using Microsoft.EntityFrameworkCore;
using web1_1.DAL.Entities;

namespace web1_1.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Wheelchair> Wheelchairs { get; set; }
        public DbSet<WheelchairGroup> WheelchairGroups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}