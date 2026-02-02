namespace AppTechnoSoft.Core.ViewModels;
public record SiteItemViewModel(int Id, string Label, string LastUpdated = "", string UpdatedBy = "")
{
    public bool Enabled { get; set; }
    public int Order { get; set; }
    public string? Content { get; set; }
    public bool Editing { get; set; }
    public List<SiteItemViewModel>? Widgets { get; set; }
}
