using JobsWeb.Enums;

namespace JobsWeb.Models;

public class Summary
{
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public string? Salary { get; set; }
    public string? Specialization { get; set; }
    public string? LastCompanyTitle { get; set; }
    public string? LastPosition { get; set; }
    public string? InstitutionTitle { get; set; }
    public string? InstitutionFaculty { get; set; }
    public string Position { get; set; }
    public int? WorkingExperienceDuration { get; set; }
    public int? GraduationYear { get; set; }
    public string? AdditionalInfo { get; set; }
    public User User { get; set; }
    public EducationLevel EducationLevel { get; set; }
    public Busyness Busyness { get; set; }
    public Schedule Schedule { get; set; }
    public List<string>? KeySkills { get; set; }
    public List<string>? AdditionalCourses { get; set; }
    public List<string>? LanguagesProficiency { get; set; }
}