using Jobs.Enums;

namespace Jobs.Models;

public class Summary
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public String Salary { get; set; }
    public String CompanyTitle { get; set; }
    public String Position { get; set; }
    public int WorkingExperienceDuration { get; set; }
    public EducationLevel EducationLevel { get; set; }
    public String InstitutionTitle { get; set; }
    public String InstitutionFaculty { get; set; }
    public int GraduationYear { get; set; }
}