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

        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(Guid id)
        {
            var company = await _repository.GetCompany(id);
            if (company == null)
            {
                return BadRequest("Cannot find company with associated id");
            }
            return Ok(company);
        }

        [HttpPost]
        public async Task<ActionResult<List<Company>>> AddCompany(Company company)
        {
            var companies = await _repository.AddCompany(company);
            return Ok(companies);
        }
    }
}
