using AppTechnoSoft.Interns.Data.Enums;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTechnoSoft.Interns.Data.Models;
public class Student
{
    public Student()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public WebExperience WebExperience { get; set; } = WebExperience.None;
    public DbExperience DbExperience { get; set; } = DbExperience.None;
    public DateTime? FormSubmitted { get; set; } = DateTime.Now;
    public Status Status { get; set; } = Status.Applied;

    [NotMapped]
    public IBrowserFile? ProfileImage { get; set; }
    public string? ProfileImagePath { get; set; }

    public int CollegeId { get; set; }
    public College? College { get; set; }

    public int TechProgramId { get; set; }
    public TechProgram? TechProgram { get; set; }

    public int? FinAccountId { get; set; }
    public FinAccount? FinAccount { get; set; }
}
