using GeoWebProject.Model;
using Microsoft.EntityFrameworkCore;

namespace GeoWebProject.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }
    }
}
