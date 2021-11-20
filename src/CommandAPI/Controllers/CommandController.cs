using System.Collections.Generic;
using CommandAPI.Data;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandController(ICommandAPIRepo repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandsModel>> GetAllCommands()
        {
            var Commandslist = _repository.GetAllCommands();
            return Ok(Commandslist);

        }
        [HttpGet]
        public ActionResult<CommandsModel> GetCommadbyID(int id)
        {
            var command = _repository.GetCommandByID();
            return Ok(command);

        }
     

        [HttpGet]
        public ActionResult<IEnumerable<string>> Geta()
        {
            return new string[]{ "Test"};
        }
        
    }
}