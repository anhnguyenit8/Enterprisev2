using Enterprisev2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Enterprisev2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }

        public DbSet<Department> Department { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationUser> User { get; set; }
        
    }
}
