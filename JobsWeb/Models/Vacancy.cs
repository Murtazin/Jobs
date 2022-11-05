using JobsWeb.Enums;

namespace JobsWeb.Models;

public class Vacancy
{
    public Guid Id { get; set; }
    public string Position { get; set; }
    public string Description { get; set; }
    public string? Salary { get; set; }
    public string Specialization { get; set; }
    public string OfficeAddress { get; set; }
    public Manager Manager { get; set; }
    public Company Company { get; set; }
    public DateTime PublicationDate { get; set; }
    public RequiredExperience RequiredExperience { get; set; }
    public Busyness Busyness { get; set; }
    public Schedule Schedule { get; set; }
    public List<Response>? Responses { get; set; }
    public List<string>? KeySkills { get; set; }
}