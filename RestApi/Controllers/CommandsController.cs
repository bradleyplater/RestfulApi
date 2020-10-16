using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Model;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IRestApiRepo _repository;
        public CommandsController(IRestApiRepo repository)
        {
            _repository = repository;      
        }

        //private readonly MockRestApiRepo _repository = new MockRestApiRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id )
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}