using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.App.Services;

namespace RequestToUniversity.App.Application.GetById.Queries
{
	public class GetByIdRequestHandler : IRequestHandler<GetByIdRequest, Domain.Model.Application>
	{
		private readonly IApplicationRepository _applicationRepository;

		public GetByIdRequestHandler(IApplicationRepository applicationRepository)
		{
			_applicationRepository = applicationRepository;
		}

		public async Task<Domain.Model.Application> Handle(GetByIdRequest request, CancellationToken cancellationToken)
		{
			var application = _applicationRepository.GetById(request.ApplicationId);

			return application;
		}
	}
}
