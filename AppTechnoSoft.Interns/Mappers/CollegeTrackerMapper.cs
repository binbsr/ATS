using AppTechnoSoft.Interns.Data.Models;
using AppTechnoSoft.Core.ViewModels;
using Humanizer;
using System.Data.Common;


namespace AppTechnoSoft.Core.Mappers;
public static class CollegeTrackerMapper
{
    public static CollegeTrackerViewModel ToViewModel(this CollegeTracker model)
    {
        if (model is null)
            return new();
 
        var viewModel = new CollegeTrackerViewModel
        {
            Id = model.Id,
            Status = model.Status,
            Phone = model.Phone,
            Email = model.Email,
            PointOfContact = model.PointOfContact,
            Notes = model.Notes,
            CollegeName = model.College.Name,
            LastUpdated = model.LastUpdated,
            LastUpdatedBy = model.LastUpdatedBy,
            
        };
        return viewModel;
    }

    public static List<CollegeTrackerViewModel> ToViewModel(this List<CollegeTracker> models) =>
        models.Select(x => x.ToViewModel()).ToList();
}

