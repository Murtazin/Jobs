using JobsWeb.Enums;

namespace JobsWeb.Models;

public class Response
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public Vacancy Vacancy { get; set; }
    public ResponseStatus Status { get; set; }
    public DateTime ResponseDate { get; set; }
}