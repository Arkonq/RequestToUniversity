using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestToUniversity.App.Application.GetAll.Queries
{
	public class GetAllRequest : IRequest<ICollection<Domain.Model.Application>>
	{
	}
}
