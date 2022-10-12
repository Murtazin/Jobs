using JobsWeb.Enums;

namespace JobsWeb.Models;

public class User
{
    public Guid Id { get; set; }
    public bool IsLoggedIn { get; set; }
    public string? Logo { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string? MailAddress { get; set; }
    public string Citizenship { get; set; }
    public string CurrentCity { get; set; }
    public string PasswordHash { get; set; }
    public string Token { get; set; }
    public Sex Sex { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Response>? Responses { get; set; }
    public List<Chat>? Chats { get; set; }
    public List<Summary>? Summaries { get; set; }
}