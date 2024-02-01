namespace AppTechnoSoft.Interns.Data.Models;
public class Instrcutor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Resume { get; set; } = string.Empty;
    public string? ProfilePath { get; set; }

    public List<Tag>? Tags { get; set; } = [];
}
