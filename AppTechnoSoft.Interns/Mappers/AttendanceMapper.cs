using AppTechnoSoft.Core.ViewModels;
using AppTechnoSoft.Interns.Data.Models;

namespace AppTechnoSoft.Core.Mappers;
public static class AttendanceMapper
{
    public static Attendance ToModel(this AttendanceViewModel viewModel)
    {
        var model = new Attendance
        {           
            Date = DateOnly.FromDateTime(viewModel.Date!.Value),
            PunchIn = TimeOnly.FromTimeSpan(viewModel.PunchIn!.Value),
            PunchOut = TimeOnly.FromTimeSpan(viewModel.PunchOut!.Value),
            WorkLog = viewModel.Task,
            StudentId = viewModel.StudentId
        };

        return model;
    }
}
