using JobsWeb.Models;
using JobsWeb.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobsWeb.Repositories;

public class CompanyRepository : ICompanyRepository
{
    private readonly DataBaseContext _context; 
    public CompanyRepository(DataBaseContext context)
    {
        this._context = context;
    }
    public async Task<List<Company>> GetCompanies()
    {
        return await _context.Companies.ToListAsync();
    }
    public async Task<Company?> GetCompany(Guid id)
    {
        return await _context.Companies.FindAsync(id);
    }
    public async Task<List<Company>> AddCompany(Company company)
    {
        await _context.Companies.AddAsync(company);
        await _context.SaveChangesAsync();
        return await _context.Companies.ToListAsync();
    }
    public async Task<List<Company>?> UpdateCompany(Company requestCompany)
    {
        var company = await _context.Companies.FindAsync(requestCompany.Id);
        if (company != null)
        {
            company.Logo = requestCompany.Logo;
            company.Title = requestCompany.Title;
            company.Vacancies = requestCompany.Vacancies;
            company.Responses = requestCompany.Responses;
            await _context.SaveChangesAsync();
            return await _context.Companies.ToListAsync();
        }
        else
        {
            return null;
        }
    }

    public async Task<List<Company>?> DeleteCompany(Guid id)
    {
        var company = await _context.Companies.FindAsync(id);
        if (company != null)
        {
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return await _context.Companies.ToListAsync();
        }
        else
        {
            return null;
        }
    }
}