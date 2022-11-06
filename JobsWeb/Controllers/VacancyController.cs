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
    public class VacancyController : ControllerBase
    {
        private readonly IVacancyRepository _repository;
        
        public VacancyController(IVacancyRepository repository)
        {
            this._repository = repository;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Vacancy>>> GetVacancies()
        {
            var vacancies = await _repository.GetVacancies();
            return Ok(vacancies);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Vacancy>> GetVacancy(Guid id)
        {
            var vacancy = await _repository.GetVacancy(id);
            if (vacancy == null)
            {
                return BadRequest("Cannot find vacancy with associated id");
            }
            return Ok(vacancy);
        }

        [HttpGet("{position}")]
        public async Task<ActionResult<List<Vacancy>>> GetVacancies(string position)
        {
            var vacancies = await _repository.GetVacancies(position);
            return Ok(vacancies);
        }

        [HttpPost]
        public async Task<ActionResult<List<Vacancy>>> AddVacancy(VacancyDTO vacancy, Guid companyId, Guid managerId)
        {
            var vacancies = await _repository.AddVacancy(vacancy, companyId, managerId);
            if (vacancies == null)
            {
                return BadRequest("Cannot create vacancy");
            }
            return Ok(vacancies);
        }
    }
}
