namespace Jobs.Models;

public class Chat
{
    public Guid Id { get; set; }
    public DateTime LastMessageSentTime { get; set; }
    public Vacancy Vacancy { get; set; }
    public User User { get; set; }
    public List<Message> Messages { get; set; }
}