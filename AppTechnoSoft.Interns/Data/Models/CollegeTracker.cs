
using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models;
public class CollegeTracker : BaseEntity
{
    public int Id { get; set; }
    public CollegeTrackerStatus Status { get; set; }
    public string Contact { get; set; }
    public string ContactPerson { get; set; }
    public string Notes { get; set; } = string.Empty;

    public int CollegeId { get; set; }
    public College? College { get; set; }
}
