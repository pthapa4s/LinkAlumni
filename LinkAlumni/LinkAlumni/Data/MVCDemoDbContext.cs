using LinkAlumni.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Alumni.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AlumniInformation> AlumniInformation { get; set; }
    }
}
