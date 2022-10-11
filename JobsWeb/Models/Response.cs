using Jobs.Enums;

namespace Jobs.Models;

public class Response
{
    public Guid Id { get; set; }
    public Vacancy Vacancy { get; set; }
    public ResponseStatus Status { get; set; }
    public DateTime ResponseDate { get; set; }
    public User User { get; set; }
}