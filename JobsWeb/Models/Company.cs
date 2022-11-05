using JobsWeb.Models;

namespace JobsWeb.Models;

public class Company
{
    public Guid Id { get; set; }
    public string? Logo { get; set; }
    public string? Description { get; set; }
    public string Title { get; set; }
    public List<Manager> Managers { get; set; }
    public List<Vacancy>? Vacancies { get; set; }
    public List<Review>? Reviews { get; set; }
}