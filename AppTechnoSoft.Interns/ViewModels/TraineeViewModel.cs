using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public record TraineeViewModel(string Id, string Name, string AvatarPath, string Program, string College)
{
    public Status Status { get; set; }
}
