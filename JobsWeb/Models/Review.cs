namespace JobsWeb.Models;

public class Review
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }
    public double Rating { get; set; }
    public Company Company { get; set; }
    public User User { get; set; }
}