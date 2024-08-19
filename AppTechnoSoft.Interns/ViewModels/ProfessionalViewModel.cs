﻿using AppTechnoSoft.Interns.Data.Enums;
using AppTechnoSoft.Interns.Data.Models;

namespace AppTechnoSoft.Core.ViewModels;
public record ProfessionalViewModel(string Id, 
    string Name, 
    string AvatarPath, 
    string Training = "", 
    string Organization = "",
    float TrainingHours = 0.0f,
    StudentAssignment[]? Assignments = null,
    Project[]? Projects = null)
{
    public Status Status { get; set; }
}
