using AppTechnoSoft.Interns.Data.Models;

namespace AppTechnoSoft.Core.ViewModels;
public class ReviewFormViewModel
{
    public ReviewFormViewModel() => Id = Guid.NewGuid().ToString();

    public string Id { get; set; }
    public string Title { get; set; } = "";
    public DateTime? Expiration { get; set; }

    public int InstructorId { get; set; }
    public Instructor? Instructor { get; set; }

    public int TrainingId { get; set; }
    public Training? Training { get; set; }
    public string Link { get; set; } = "";
    public int ReviewCount { get; set; }
    public string Created { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; }
    public string LastUpdatedBy { get; set; } = string.Empty;
}
