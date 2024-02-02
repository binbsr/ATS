namespace AppTechnoSoft.Interns.Data.Models;
public class Attendance
{
    public int Id { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public TimeOnly? PunchIn { get; set; }
    public TimeOnly? PunchOut { get; set; }
    public string? WorkLog { get; set; }

    public required string StudentId { get; set; }
    public Student Student { get; set; } = null!;
}
