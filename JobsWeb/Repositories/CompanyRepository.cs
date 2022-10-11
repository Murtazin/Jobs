using Jobs.Models;
using JobsWeb.Interfaces;
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
    public async Task<Company> GetCompany(Guid id)
    {
        return await _context.Companies.FindAsync(id);
    }
}