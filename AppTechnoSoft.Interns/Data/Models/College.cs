﻿namespace AppTechnoSoft.Interns.Data.Models;
public class College : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
}
