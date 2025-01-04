namespace AppTechnoSoft.Interns.Data.Models.Workshop;
public class Workshop
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    public float Quote { get; set; }
}
