namespace Jobs.Models;

public class Message
{
    public Guid Id { get; set; }
    public DateTime DepartureTime { get; set; }
    public Boolean IsViewed { get; set; }
    public String Content { get; set; }
    public User Sender { get; set; }
}