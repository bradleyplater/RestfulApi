using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
	public class SqlCommanderRepo : IRestApiRepo
	{
		private readonly RestApiContext _context;

		public SqlCommanderRepo(RestApiContext context)
		{
			_context = context;
		}
		public IEnumerable<Command> GetAllCommands()
		{
			return _context.Commands.ToList();
		}

		public Command GetCommandById(int id)
		{
			return _context.Commands.FirstOrDefault(p => p.Id == id);
		}
	}
}
