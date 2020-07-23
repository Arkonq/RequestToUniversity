using Domain.DataAccess;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.App.Services;

namespace Web.App.Implementations
{
	public class ApplicationRepository : IApplicationRepository
	{
		public ProjectDataContext _context;

		public ApplicationRepository(ProjectDataContext context)
		{
			_context = context;
		}

		public Application GetById(int id)
		{
			return _context.Applications.Find(id);
		}

		public ICollection<Application> GetAll()
		{
			return _context.Applications.ToList();
		}

		public Application Create(Application application)
		{
			var createdApplication = _context.Add(application);
			_context.SaveChanges();

			return createdApplication.Entity;
		}

		public Application Update(int id, Application application)
		{
			var applicationToUpdate = GetById(id);

			if (applicationToUpdate == null) return null;

			applicationToUpdate= application;
			//applicationToUpdate.IIN = application.IIN;
			//applicationToUpdate.Score = application.Score;
			//applicationToUpdate.Profile1 = application.Profile1;
			//applicationToUpdate.Profile2 = application.Profile2;
			//applicationToUpdate.University = application.University;

			_context.Applications.Update(applicationToUpdate);
			_context.Entry(application).State = EntityState.Modified;
			_context.SaveChanges();

			return applicationToUpdate;
		}

		public Application Delete(int id)
		{
			var applicationToDelete = GetById(id);

			if (applicationToDelete == null) return null;

			_context.Applications.Remove(applicationToDelete);
			_context.SaveChanges();

			return applicationToDelete;
		}
	}
}
