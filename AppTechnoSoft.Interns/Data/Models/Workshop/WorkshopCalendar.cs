namespace AppTechnoSoft.Interns.Data.Models.Workshop;
public class WorkshopCalendar
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DurationHoursPerDay { get; set; }
    public WorkshopStatus Status { get; set; }

    public DateTime RequestedDate { get; set; }
    public string RequestedBy { get; set; } = string.Empty;


    public Guid WorkshopId { get; set; }
    public Workshop? Workshop { get; set; }

    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }
}
