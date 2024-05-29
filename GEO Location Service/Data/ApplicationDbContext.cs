using GEO_Location_Service.Models;
using Microsoft.EntityFrameworkCore;

namespace GEO_Location_Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
        public DbSet<Friends> Friends { get; set; }


    }

}
