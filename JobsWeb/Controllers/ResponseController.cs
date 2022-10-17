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
    public class ResponseController : ControllerBase
    {
        private readonly IResponseRepository _repository;
        
        public ResponseController(IResponseRepository repository)
        {
            this._repository = repository;
        }
        
        [HttpPost]
        public async Task<ActionResult<List<Response>>> AddResponse(Response response)
        {
            var responses = await _repository.AddResponse(response);
            return Ok(responses);
        }
    }
}
