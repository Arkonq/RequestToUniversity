using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.DataAccess
{
	public class ProjectDataContext : DbContext
	{
		public virtual DbSet<Application> Applications { get; set; }
		public ProjectDataContext()
		{

		}

		public ProjectDataContext(DbContextOptions<ProjectDataContext> options) : base(options)
		{

		}

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjectDatabase;Trusted_Connection=True;MultipleActiveResiltSets=True");
		//	base.OnConfiguring(optionsBuilder);
		//}
	}
}
