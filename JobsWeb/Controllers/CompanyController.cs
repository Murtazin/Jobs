using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jobs.Models;
using JobsWeb.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobsWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _repository;
        public CompanyController(ICompanyRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetCompanies()
        {
            var companies = await _repository.GetCompanies();
            return Ok(companies);
        }
    }
}
