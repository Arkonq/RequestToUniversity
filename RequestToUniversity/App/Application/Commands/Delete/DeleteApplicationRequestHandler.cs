using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.App.Services;

namespace RequestToUniversity.App.Application.Commands.Delete
{
	public class DeleteApplicationRequestHandler : IRequestHandler<DeleteApplicationRequest, Domain.Model.Application>
	{
		private readonly IApplicationRepository _applicationRepository;

		public DeleteApplicationRequestHandler(IApplicationRepository applicationRepository)
		{
			_applicationRepository = applicationRepository;
		}

		public async Task<Domain.Model.Application> Handle(DeleteApplicationRequest request, CancellationToken cancellationToken)
		{
			return _applicationRepository.Delete(request.ApplicationId);
		}
	}
}
