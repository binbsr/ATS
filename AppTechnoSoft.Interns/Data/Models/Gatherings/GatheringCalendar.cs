using AppTechnoSoft.Interns.Data.Models.Consultant;

namespace AppTechnoSoft.Interns.Data.Models.Gatherings;
public class GatheringCalendar
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DurationHoursPerDay { get; set; }
    public GatheringStatus Status { get; set; }

    public DateTime RequestedDate { get; set; }
    public string RequestedBy { get; set; } = string.Empty;


    public Guid WorkshopId { get; set; }
    public Gathering? Workshop { get; set; }

    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public List<Instructor> Consultants { get; set; } = [];
}
