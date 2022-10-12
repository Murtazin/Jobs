using JobsWeb.Models;

namespace JobsWeb.Models;

public class Company
{
    public Guid Id { get; set; }
    public string? Logo { get; set; }
    public string? Description { get; set; }
    public string? WebSite { get; set; }
    public string Title { get; set; }
    public List<Vacancy>? Vacancies { get; set; }
    public List<Response>? Responses { get; set; }
    public List<Chat>? Chats { get; set; }
}