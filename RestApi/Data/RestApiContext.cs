using Microsoft.EntityFrameworkCore;
using RestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi.Data
{
	public class RestApiContext : DbContext
	{
		public RestApiContext(DbContextOptions<RestApiContext> opt)	: base(opt)
		{

		}

		public DbSet<Command> Commands { get; set; }
	}
}
