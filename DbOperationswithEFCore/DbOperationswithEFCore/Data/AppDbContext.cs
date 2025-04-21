using Microsoft.EntityFrameworkCore;

namespace DbOperationswithEFCore.Data
{
	public class AppDbContext : DbContext //Dbcontext is just a bridge b/w yr Application and Database and options areto configure the connection string, logging, lazy loading, etc.
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) // This is a constructor that takes in DbContextOptions<AppDbContext> as a parameter and base is to send to Parent dbcontext class.


		{
		}


	}
}

