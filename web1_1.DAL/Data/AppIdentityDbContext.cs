using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web1_1.DAL.Entities;

namespace web1_1.DAL.Data
{
    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser>
    {


        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
        }
    }
}