namespace AppTechnoSoft.Interns.Data.Models.Gatherings;
public class Gathering : BaseEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    public float Quote { get; set; }
    public bool QuotePerAttendee { get; set; } = false;
    public int MaxAttendees { get; set; }
    public GatheringType Type { get; set; }
}
