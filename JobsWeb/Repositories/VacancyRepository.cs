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
    public async Task<List<Vacancy>> AddVacancy(VacancyDTO vacancy, Guid companyId, Guid managerId)
    {
        var newVacancy = new Vacancy
        {
            Id = new Guid(),
            Busyness = vacancy.Busyness,
            Company = await _context.Companies.FindAsync(companyId),
            Description = vacancy.Description,
            KeySkills = vacancy.KeySkills,
            Manager = await _context.Managers.FindAsync(managerId),
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