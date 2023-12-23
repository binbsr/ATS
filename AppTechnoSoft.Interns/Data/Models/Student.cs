using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;    
    public DateTime? FormSubmitted { get; set; } = DateTime.Now;
    public Status Status { get; set; } = Status.Applied;

    public int CollegeId { get; set; }
    public College? College { get; set; }

    public int TechProgramId { get; set; }
    public TechProgram? TechProgram { get; set; }

    public int? FinAccountId { get; set; }
    public FinAccount? FinAccount { get; set; }
}
