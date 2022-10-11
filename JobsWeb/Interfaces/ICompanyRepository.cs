using Jobs.Models;

namespace JobsWeb.Interfaces;

public interface ICompanyRepository
{
    Task<List<Company>> GetCompanies();
    Task<Company> GetCompany(Guid id);
}