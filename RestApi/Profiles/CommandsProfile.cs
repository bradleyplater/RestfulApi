using AutoMapper;
using RestApi.Dtos;
using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Profiles
{
	public class CommandsProfile : Profile
	{
		public CommandsProfile()
		{
			CreateMap<Command, CommandReadDto>();
		}
	}
}
