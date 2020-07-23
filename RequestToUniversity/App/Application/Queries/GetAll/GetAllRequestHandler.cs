using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.App.Services;

namespace RequestToUniversity.App.Application.GetAll.Queries
{
	public class GetAllRequestHandler : IRequestHandler<GetAllRequest, ICollection<Domain.Model.Application>>
	{
		private IApplicationRepository _applicationRepository;

		public GetAllRequestHandler(IApplicationRepository applicationRepository)
		{
			_applicationRepository = applicationRepository;
		}

		public async Task<ICollection<Domain.Model.Application>> Handle(GetAllRequest request, CancellationToken cancellationToken)
		{
			return _applicationRepository.GetAll();
		}
	}
}
