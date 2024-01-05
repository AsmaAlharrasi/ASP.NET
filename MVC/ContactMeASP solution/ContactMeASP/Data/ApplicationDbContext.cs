using ContactMeASP.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactMeASP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) :base(option)
        {
            
        }
        public DbSet<ToDo> ToDos { get; set; } 
    }
}
