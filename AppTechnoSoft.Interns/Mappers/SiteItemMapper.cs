using AppTechnoSoft.Core.ViewModels;
using AppTechnoSoft.Interns.Data.Models;
using AppTechnoSoft.Interns.Data.Models.Sites;
using Humanizer;

namespace AppTechnoSoft.Core.Mappers;

public static class SiteItemMapper
{
    public static SiteItemViewModel ToViewModel(this Section model) => new(Id: model.Id, Label: model.Title)
    {
        Enabled = model.Enabled,
        Order = model.Order,
        Content = model.Content,
        Editing = false,
        Widgets = model.Widgets?.ToViewModel()
    };

    public static SiteItemViewModel ToViewModel(this Widget model) => new(Id: model.Id, Label: model.Description, LastUpdated: model.LastUpdated.Humanize(), UpdatedBy: model.LastUpdatedBy ?? "") 
    {
        Content = model.HtmlContent,
        Editing = false
    };

    public static List<SiteItemViewModel> ToViewModel(this List<Section> models)
        => [.. models.Select(x => x.ToViewModel())];

    public static List<SiteItemViewModel> ToViewModel(this List<Widget> models)
        => [.. models.Select(x => x.ToViewModel())];
}
