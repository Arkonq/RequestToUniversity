using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.App.Services;

namespace RequestToUniversity.App.Application.Commands.Update
{
	public class UpdateApplicationRequestHandler : IRequestHandler<UpdateApplicationRequest, Domain.Model.Application>
	{
		private readonly IApplicationRepository _applicationRepository;
		private readonly IMapper _mapper;

		public UpdateApplicationRequestHandler(IApplicationRepository applicationRepository, IMapper mapper)
		{
			_applicationRepository = applicationRepository;
			_mapper = mapper;
		}

		public async Task<Domain.Model.Application> Handle(UpdateApplicationRequest request, CancellationToken cancellationToken)
		{
			var application = _mapper.Map<Domain.Model.Application>(request.Command);
			return _applicationRepository.Update(request.ApplicationId, application);
		}
	}
}
