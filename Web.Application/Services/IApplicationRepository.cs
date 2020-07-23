using Domain.Model;
using System.Collections.Generic;
using Domain.DataAccess;

namespace Web.App.Services
{
	public interface IApplicationRepository
	{
		Application GetById(int id);

		ICollection<Application> GetAll();

		Application Create(Application application);
		
		Application Update(int id, Application application);

		Application Delete(int id);
	}
}
