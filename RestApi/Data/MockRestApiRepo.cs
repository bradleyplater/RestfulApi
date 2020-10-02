using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
	public class MockRestApiRepo : IRestApiRepo
	{
		public IEnumerable<Command> GetAllCommands()
		{
			var commands = new List<Command>
			{
				new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & pan" },
				new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife and chopping board" },
				new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place tea bag in cup", Platform = "Kettle & cup" }
			};
			return commands;
		}

		public Command GetCommandById(int id)
		{
			return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & pan" };
		}
	}
}
