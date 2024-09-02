using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public class CollegeTrackerViewModel
{
    public int Id { get; set; }
    public CollegeTrackerStatus Status { get; set; }
    public string Phone { get; set; }
    public string? Email { get; set; }
    public string PointOfContact { get; set; }
    public string Notes { get; set; } = string.Empty;
    public string CollegeName { get; set; }
    public int PhoneCount {get; set;}
    public int AdminOrientationCount {get; set;}
    public int StudentOrientationCount {get; set;}

    public DateTime? LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; } = string.Empty;

}
