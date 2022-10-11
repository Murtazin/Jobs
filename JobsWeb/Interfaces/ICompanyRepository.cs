using Jobs.Models;

namespace JobsWeb.Interfaces;

public interface ICompanyRepository
{
    Task<List<Company>> GetCompanies();
    Task<Company?> GetCompany(Guid id);
    Task<List<Company>> AddCompany(Company company);
    Task<List<Company>?> UpdateCompany(Company company);
    Task<List<Company>?> DeleteCompany(Guid id);
}