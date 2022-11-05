namespace JobsWeb.Models;

public class ManagerMessage
{
    public Guid Id { get; set; }
    public bool IsViewed { get; set; }
    public string Content { get; set; }
    public Manager Sender { get; set; }
    public DateTime DepartureTime { get; set; }
}