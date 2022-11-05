using JobsWeb.Models;

namespace JobsWeb.Models;

public class Chat
{
    public Guid Id { get; set; }
    public DateTime LastMessageSentTime { get; set; }
    public Vacancy Vacancy { get; set; }
    public User User { get; set; }
    public List<UserMessage>? UserMessages { get; set; }
    public List<ManagerMessage>? ManagerMessages { get; set; }
}