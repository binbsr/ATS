
using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models;
public class CollegeTracker : BaseEntity
{
    public int Id { get; set; }
    public CollegeTrackerStatus Status { get; set; }
    public string Phone { get; set; }
    public string? Email { get; set; }
    public string PointOfContact { get; set; }
    public string Notes { get; set; } = string.Empty;

    public int CollegeId { get; set; }
    public College? College { get; set; }
}
