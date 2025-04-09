using Microsoft.EntityFrameworkCore;

namespace Rex_Azure_App.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }

        public DbSet<Person> Person { get; set; }
    }
}
