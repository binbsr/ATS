namespace AppTechnoSoft.Interns.Data.Models;
public class BaseEntity
{
    public BaseEntity()
    {
        Created = DateTime.Now;
    }

    public DateTime? Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; }
}
