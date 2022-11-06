using JobsWeb.Enums;
using JobsWeb.Interfaces;
using JobsWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsWeb.Repositories;

public class VacancyRepository : IVacancyRepository
{
    private readonly DataBaseContext _context;

    public VacancyRepository(DataBaseContext context)
    {
        this._context = context;
    }

    public async Task<List<Vacancy>> GetVacancies()
    {
        return await _context.Vacancies.ToListAsync();
    }

    public async Task<Vacancy?> GetVacancy(Guid id)
    {
        return await _context.Vacancies.FindAsync(id);
    }

    public async Task<List<Vacancy>> GetVacancies(string position)
    {
        return await _context.Vacancies.Where(x => x.Position == position).ToListAsync();
    }

    public async Task<List<Vacancy>?> AddVacancy(VacancyDTO vacancy, Guid companyId, Guid managerId)
    {
        var company = (await _context.Companies.Where(company => company.Id == companyId)
            .ToListAsync()).First();
        var manager = (await _context.Managers.Where(manager => manager.Id == managerId)
            .ToListAsync()).First();

        var newVacancy = new Vacancy
        {
            Id = new Guid(),
            Busyness = vacancy.Busyness,
            Company = company,
            Description = vacancy.Description,
            KeySkills = vacancy.KeySkills,
            Manager = manager,
            Specialization = vacancy.Specialization,
            OfficeAddress = vacancy.OfficeAddress,
            Position = vacancy.Position,
            PublicationDate = DateTime.Now,
            RequiredExperience = vacancy.RequiredExperience
        };
        await _context.Vacancies.AddAsync(newVacancy);
        await _context.SaveChangesAsync();
        return await _context.Vacancies.ToListAsync();
    }
}