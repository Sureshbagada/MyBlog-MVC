using Microsoft.EntityFrameworkCore;
using MyBlog.Web.Models;

namespace MyBlog.Web.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
                
        }

        public DbSet<categories> Categories { get; set; }
        public DbSet<articles> Articles { get; set; }
        public DbSet<failed_jobs> Failed_Jobs { get; set; }
    }
}
