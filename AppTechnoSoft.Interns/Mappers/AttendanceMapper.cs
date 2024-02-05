using AppTechnoSoft.Core.ViewModels;
using AppTechnoSoft.Interns.Data.Models;

namespace AppTechnoSoft.Core.Mappers;
public static class AttendanceMapper
{
    public static Attendance ToModel(this AttendanceViewModel viewModel)
    {
        var model = new Attendance
        {           
            Id = viewModel.Id,
            Date = DateOnly.FromDateTime(viewModel.Date!.Value),
            PunchIn = TimeOnly.FromTimeSpan(viewModel.PunchIn!.Value),
            PunchOut = TimeOnly.FromTimeSpan(viewModel.PunchOut!.Value),
            WorkLog = viewModel.Task,
            StudentId = viewModel.StudentId
        };

        return model;
    }

    public static AttendanceViewModel ToViewModel(this Attendance model)
    {
        var viewModel = new AttendanceViewModel
        {
            Id = model.Id,
            Date = model.Date.ToDateTime(TimeOnly.MinValue),
            PunchIn = model.PunchIn!.Value.ToTimeSpan(),
            PunchOut = model.PunchOut!.Value.ToTimeSpan(),
            Task = model.WorkLog!,
            StudentId = model.StudentId
        };

        return viewModel;
    }

    public static List<AttendanceViewModel> ToViewModel(this List<Attendance> models) 
        => models.Select(x => x.ToViewModel()).ToList();
}
