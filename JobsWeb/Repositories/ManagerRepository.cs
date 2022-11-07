using JobsWeb.Interfaces;
using JobsWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace JobsWeb.Repositories;

public class ManagerRepository : IManagerRepository
{
    private readonly DataBaseContext _context;

    public ManagerRepository(DataBaseContext context)
    {
        this._context = context;
    }

    public async Task<List<Manager>> GetManagers()
    {
        return await _context.Managers.ToListAsync();
    }

    public async Task<Manager?> GetManager(Guid id)
    {
        return await _context.Managers.FindAsync(id);
    }

    public async Task<List<Manager>> AddManager(ManagerDTO manager)
    {
        var companies = await _context.Companies.Where(company =>
                company.Title == manager.CompanyTitle)
            .ToListAsync();

        var company = companies.FirstOrDefault(new Company { Id = new Guid(), Title = manager.CompanyTitle });

        var newManager = new Manager
        {
            Id = new Guid(),
            City = manager.City,
            FirstName = manager.FirstName,
            LastName = manager.LastName,
            MailAddress = manager.MailAddress,
            PhoneNumber = manager.PhoneNumber,
            Company = company
        };

        await _context.Managers.AddAsync(newManager);
        await _context.SaveChangesAsync();
        return await _context.Managers.ToListAsync();
    }

    public async Task<List<Manager>?> UpdateManager(ManagerPutDTO modifiedManager)
    {
        var manager = await _context.Managers.FindAsync(modifiedManager.Id);
        if (manager != null)
        {
            manager.City = modifiedManager.City;
            manager.FirstName = modifiedManager.FirstName;
            manager.LastName = modifiedManager.LastName;
            manager.MailAddress = modifiedManager.MailAddress;
            manager.PhoneNumber = modifiedManager.PhoneNumber;
            await _context.SaveChangesAsync();
            return await _context.Managers.ToListAsync();
        }
        else
        {
            return null;
        }
    }

    public async Task<List<Manager>?> DeleteManager(Guid id)
    {
        var manager = await _context.Managers.FindAsync(id);
        if (manager != null)
        {
            _context.Managers.Remove(manager);
            await _context.SaveChangesAsync();
            return await _context.Managers.ToListAsync();
        }
        else
        {
            return null;
        }
    }
}