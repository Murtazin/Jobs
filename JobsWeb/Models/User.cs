using Jobs.Enums;

namespace Jobs.Models;

public class User
{
    public Guid Id { get; set; }
    public Sex Sex { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Boolean IsLoggedIn { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String PhoneNumber { get; set; }
    public String MailAddress { get; set; }
    public String Citizenship { get; set; }
    public String CurrentCity { get; set; }
    public String PasswordHash { get; set; }
    public String Token { get; set; }
    public List<Response>? Responses { get; set; }
    public List<Chat>? Chats { get; set; }
    public List<Summary>? Summaries { get; set; }
}