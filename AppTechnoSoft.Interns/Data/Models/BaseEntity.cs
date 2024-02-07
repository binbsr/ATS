namespace AppTechnoSoft.Interns.Data.Models;
public class BaseEntity
{    
    public DateTime? Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; }

    public BaseEntity AddLastUpdatedStamps(string? lastUpdateUserName)
    {
        LastUpdated = DateTime.Now;
        LastUpdatedBy = lastUpdateUserName;
        return this;
    }

    public BaseEntity AddCreatedStamps(string? createUserName)
    {
        Created = DateTime.Now;
        CreatedBy = createUserName;
        return this;
    }
}
