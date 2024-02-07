namespace AppTechnoSoft.Interns.Data.Models;
public class Batch: BaseEntity
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<Team>? Teams { get; set; }
}
