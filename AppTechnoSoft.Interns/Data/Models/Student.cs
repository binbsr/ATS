using AppTechnoSoft.Interns.Data.Enums;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTechnoSoft.Interns.Data.Models;
public class Student : BaseEntity
{
    public Student()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public GeneralProgrammingExperience GeneralProgramming { get; set; } = GeneralProgrammingExperience.None;
    public WebExperience WebExperience { get; set; } = WebExperience.None;
    public DbExperience DbExperience { get; set; } = DbExperience.None;
    public DateTime? FormSubmitted { get; set; } = DateTime.UtcNow;
    public Status Status { get; set; } = Status.Applied;
    public ApplicantType ApplicantType { get; set; } = ApplicantType.StudentInternship;

    [NotMapped]
    public IBrowserFile? ProfileImage { get; set; }
    public string? ProfileImagePath { get; set; }

    public int CollegeId { get; set; }
    public College? College { get; set; }

    public int TechProgramId { get; set; }
    public TechProgram? TechProgram { get; set; }   
   
    public int? TeamId { get; set; }
    public Team? Team { get; set; }

    public int? BatchId { get; set; }
    public Batch? Batch { get; set; }

    public string? ApplicationUserId { get; set; }
    public ApplicationUser? User { get; set; }

    public FinAccount? FinAccount { get; set; }
}
