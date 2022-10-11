using Jobs.Enums;

namespace Jobs.Models;

public class Vacancy
{
    public Guid Id { get; set; }
    public DateTime PublicationDate { get; set; }
    public String Position { get; set; }
    public String Description { get; set; }
    public String Location { get; set; }
    public String Salary { get; set; }
    public RequiredExperience RequiredExperience { get; set; }
    public Busyness Busyness { get; set; }
    public List<NavigationWords>? NavigationWords { get; set; }
    public List<String> KeySkills { get; set; }
    public Company Company { get; set; }
}