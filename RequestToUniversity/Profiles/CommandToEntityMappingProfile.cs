using AutoMapper;
using RequestToUniversity.App.Application.Commands.Create;
using RequestToUniversity.App.Application.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestToUniversity.Profiles
{
	public class CommandToEntityMappingProfile : Profile
	{
		CreateMap<CreateApplicationCommand, Application>();
		CreateMap<UpdateApplicationCommand, Application>();		
	}
}
