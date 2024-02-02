namespace AppTechnoSoft.Core.ViewModels;
public class AttendanceViewModel
{
    public DateTime? Date { get; set; }
    public TimeSpan? PunchIn { get; set; }
    public TimeSpan? PunchOut { get; set; }
    public string Task { get; set; } = string.Empty;
    public string StudentId { get; set; } = string.Empty;
}
