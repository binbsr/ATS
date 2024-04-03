using AppTechnoSoft.Interns.Extensions;

namespace AppTechnoSoft.Interns.Data.Models;
public class Attendance
{
    public int Id { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow.ToNepalTime());
    public TimeOnly? PunchIn { get; set; } = TimeOnly.MinValue;
    public TimeOnly? PunchOut { get; set; } = TimeOnly.MinValue;
    public string? WorkLog { get; set; }

    public string StudentId { get; set; } = string.Empty;
    public Student Student { get; set; } = null!;
}
