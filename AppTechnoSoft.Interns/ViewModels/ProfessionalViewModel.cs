using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public record ProfessionalViewModel(string Id, string Name, string AvatarPath, string Training, string Organization)
{
    public Status Status { get; set; }
}
