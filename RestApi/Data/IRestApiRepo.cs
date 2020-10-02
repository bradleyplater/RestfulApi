using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
	public interface IRestApiRepo
	{
		IEnumerable<Command> GetAllCommands();
		Command GetCommandById(int id);
	}
}
