using AppTechnoSoft.Interns.Data.Models.Consultant;

namespace AppTechnoSoft.Interns.Data.Models.Workshop;
public class WorkshopConsultant
{
    public int WorkshopCalendarId { get; set; }
    public WorkshopCalendar? WorkshopCalendar { get; set; }

    public int InstructorId { get; set; }
    public Instructor? Instructor { get; set; }
}
