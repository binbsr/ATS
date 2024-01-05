namespace AppTechnoSoft.Interns.Data.Models;
public class Team : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}
