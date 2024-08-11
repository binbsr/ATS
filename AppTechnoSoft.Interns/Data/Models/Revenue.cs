﻿using AppTechnoSoft.Interns.Data.Enums;
using AppTechnoSoft.Interns.Extensions;

namespace AppTechnoSoft.Interns.Data.Models;
public class Revenue : BaseEntity
{
    public int Id { get; set; }
    public RevenueSource Source { get; set; } = RevenueSource.ProfessionalTraining;
    public string Particulars { get; set; } = string.Empty;
    public float Amount { get; set; }
    public DateTime? Date { get; set; } = DateTime.UtcNow;
}
