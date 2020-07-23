using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestToUniversity.App.Application.GetById.Queries
{
	public class GetByIdRequest : IRequest<Domain.Model.Application>
	{
		public int ApplicationId { get; }
		public GetByIdRequest(int id)
		{
			ApplicationId = id;
		}
	}
}
