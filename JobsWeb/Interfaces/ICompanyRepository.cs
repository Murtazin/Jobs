using JobsWeb.Models;

namespace JobsWeb.Interfaces;

public interface ICompanyRepository
{
    Task<List<Company>> GetCompanies();
    Task<Company?> GetCompany(Guid id);
    Task<List<Company>?> UpdateCompany(CompanyPutDTO modifiedCompany);
    Task<List<Company>?> DeleteCompany(Guid id);
}