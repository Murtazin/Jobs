using JobsWeb.Models;

namespace JobsWeb.Interfaces;

public interface IVacancyRepository
{
    Task<List<Vacancy>> GetVacancies();
    Task<Vacancy?> GetVacancy(Guid id);
    Task<List<Vacancy>> GetVacancies(string position);
    Task<List<Vacancy>?> AddVacancy(VacancyDTO vacancy, Guid companyId, Guid managerId);
    Task<List<Vacancy>?> UpdateVacancy(VacancyDTO modifiedVacancy, Guid vacancyId);
    Task<List<Vacancy>?> DeleteVacancy(Guid id);
}