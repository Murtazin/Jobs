using JobsWeb.Models;

namespace JobsWeb.Interfaces;

public interface IManagerRepository
{
    Task<List<Manager>> GetManagers();
    Task<Manager?> GetManager(Guid id);
    Task<List<Manager>> AddManager(ManagerDTO manager);
}