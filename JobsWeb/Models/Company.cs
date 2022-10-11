namespace Jobs.Models;

public class Company
{
    public Guid Id { get; set; }
    public String Logo { get; set; }
    public String Title { get; set; }
    public List<Vacancy>? Vacancies { get; set; }
    public List<Response>? Responses { get; set; }
}