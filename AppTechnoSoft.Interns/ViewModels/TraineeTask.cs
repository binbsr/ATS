﻿using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Core.ViewModels;
public record TraineeTask(DateTime Date, string Task, string Details, TaskType TaskType);

