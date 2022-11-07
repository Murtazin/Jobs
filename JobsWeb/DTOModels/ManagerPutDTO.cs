namespace JobsWeb;

public class ManagerPutDTO
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string MailAddress { get; set; }
    public string City { get; set; }
}