using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Web.App.Services;

namespace RequestToUniversity.App.Application.Commands.Create
{
	public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Domain.Model.Application>
	{
		private readonly IApplicationRepository _applicationRepository;
		private readonly IMapper _mapper;
		public CreateApplicationCommandHandler(IApplicationRepository applicationRepository, IMapper mapper)
		{
			_applicationRepository = applicationRepository;
			_mapper = mapper;
		}

		public async Task<Domain.Model.Application> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
		{
			var application = _mapper.Map<Domain.Model.Application>(request);
			return _applicationRepository.Create(application);
		}
	}
}
