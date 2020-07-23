using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.DataAccess.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddDataContext(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<ProjectDataContext>(options => 
				options.UseSqlServer(configuration.GetConnectionString("ProjectsConnectionString")));
			return services;
		}
	}
}
