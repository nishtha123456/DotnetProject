using ArrayList.Model;

using Microsoft.EntityFrameworkCore;

namespace ArrayList.Data
{
    public class ApplicationDbContaxt :DbContext
        
    {
        public ApplicationDbContaxt(DbContextOptions<ApplicationDbContaxt>options) :base(options)
        {

        }
        public DbSet <Student> Student { get; set; }
    }
}
