using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestToUniversity.App.Application.Commands.Delete
{
	public class DeleteApplicationRequest : IRequest<Domain.Model.Application>
	{
		public int ApplicationId { get; set; }

		public DeleteApplicationRequest(int id)
		{
			ApplicationId = id;
		}
	}
}
