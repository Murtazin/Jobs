using JobsWeb.Models;

namespace JobsWeb;

public class ResponseDTO
{
    public User User { get; set; }
    public Vacancy Vacancy { get; set; }
    public DateTime ResponseDate { get; set; }
}