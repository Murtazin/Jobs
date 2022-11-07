using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobsWeb.Interfaces;
using JobsWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobsWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IManagerRepository _repository;

        public ManagerController(IManagerRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Manager>>> GetManagers()
        {
            var managers = await _repository.GetManagers();
            return Ok(managers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Manager>> GetManager(Guid id)
        {
            var manager = await _repository.GetManager(id);
            if (manager == null)
            {
                return BadRequest("Cannot find manager with associated id");
            }

            return Ok(manager);
        }

        [HttpPost]
        public async Task<ActionResult<List<Manager>>> AddManager(ManagerDTO manager)
        {
            var managers = await _repository.AddManager(manager);
            return Ok(managers);
        }

        [HttpPut]
        public async Task<ActionResult<List<Manager>>> UpdateManager(ManagerPutDTO modifiedManager)
        {
            var managers = await _repository.UpdateManager(modifiedManager);
            if (managers == null)
            {
                return BadRequest("Failed to update manager data");
            }

            return Ok(managers);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Manager>>> DeleteManager(Guid id)
        {
            var managers = await _repository.DeleteManager(id);
            if (managers == null)
            {
                return BadRequest("Failed to delete manager");
            }
        
            return Ok(managers);
        }
    }
}