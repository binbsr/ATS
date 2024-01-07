namespace AppTechnoSoft.Interns.Data.Models;
public class Team : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ProjectTitle { get; set; }
    public string? ProjectDetails { get; set; }
    public string? Description { get; set; }

    public int? BatchId { get; set; }
    public Batch? Batch { get; set; }
}
