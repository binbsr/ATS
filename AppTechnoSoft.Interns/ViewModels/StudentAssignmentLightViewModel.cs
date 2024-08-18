using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public record StudentAssignmentLightViewModel(
    string Title,
    DateTime? ReturnDate,
    DateTime? Deadline,
    byte Score,
    AssignmentStatus Status)
{
}
