using AppTechnoSoft.Interns.Data.Models.Consultant;

namespace AppTechnoSoft.Interns.Data.Models.Gatherings;
public class GatheringAttendees
{
    public int Id { get; set; }

    public int GatheringCalendarId { get; set; }
    public GatheringCalendar? GatheringCalendar { get; set; }

    public int StudentId { get; set; }
    public Student? Student { get; set; }
}
