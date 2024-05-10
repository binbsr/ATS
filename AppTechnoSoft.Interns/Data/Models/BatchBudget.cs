﻿using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models;
public class BatchBudget
{
    public int Id { get; set; }
    public BudgetType BudgetType { get; set; }
    public float Allocation { get; set; }
    public float Amount { get; set; }
    public string? Notes { get; set; }

    public int BatchId { get; set; }
    public Batch? Batch { get; set; }
}
