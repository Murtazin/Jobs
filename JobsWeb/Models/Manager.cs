namespace JobsWeb.Models;

public class Manager
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAddress { get; set; }
    public string PasswordHash { get; set; }
    public string Token { get; set; }
    public Company Company { get; set; }
    public List<Chat>? Chats { get; set; }
}