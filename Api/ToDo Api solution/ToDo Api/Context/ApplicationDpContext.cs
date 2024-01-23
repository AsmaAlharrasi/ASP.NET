using Microsoft.EntityFrameworkCore;
using ToDo_Api.Models;

namespace ToDo_Api.Context
{
	public class ApplicationDpContext :DbContext 
	{
        public ApplicationDpContext(DbContextOptions<ApplicationDpContext> options ) : base (options)
        {
            
        }

        public DbSet<ToDo> toDos { get; set; }
    }
}
