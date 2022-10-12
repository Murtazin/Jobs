namespace JobsWeb.Models;

public class Message
{
    public Guid Id { get; set; }
    public bool IsViewed { get; set; }
    public string Content { get; set; }
    public User Sender { get; set; }
    public DateTime DepartureTime { get; set; }
}