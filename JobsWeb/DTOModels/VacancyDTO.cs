using JobsWeb.Enums;

namespace JobsWeb;

public class VacancyDTO
{
    public string Position { get; set; }
    public string OfficeAddress { get; set; }
    public string Specialization { get; set; }
    public string Description { get; set; }
    public string? Salary { get; set; }
    public Busyness Busyness { get; set; }
    public Schedule Schedule { get; set; }
    public RequiredExperience RequiredExperience { get; set; }
    public List<string>? KeySkills { get; set; }
}