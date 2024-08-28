using AppTechnoSoft.Interns.Data.Models;
using AppTechnoSoft.Core.ViewModels;
using Humanizer;

namespace AppTechnoSoft.Core.Mappers;
public static class ReviewFormMapper
{
    public static ReviewFormViewModel ToViewModel(this ReviewForm model)
    {
        var viewModel = new ReviewFormViewModel
        {
            Id = model.Id,
            Title = model.Title,
            Expiration = model.Expiration,
            InstructorId = model.InstructorId,
            Instructor = model.Instructor,
            TrainingId = model.TrainingId,
            Training = model.Training,
            Created = model?.Created?.Humanize() ?? "N/A",
            CreatedBy = model?.CreatedBy ?? "N/A",
            Link = $"/ats/feedback/{model?.Id}"
        };

        return viewModel;
    }
    
    public static List<ReviewFormViewModel> ToViewModel(this List<ReviewForm> models) => 
        models.Select(x => x.ToViewModel()).ToList();
}
