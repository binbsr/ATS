﻿using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTechnoSoft.Interns.Data.Models;
public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Resume { get; set; } = string.Empty;
    public string? ProfilePath { get; set; }
   
    [NotMapped]
    public IBrowserFile? Profile { get; set; }

    public List<Tag>? Tags { get; set; } = [];
}
