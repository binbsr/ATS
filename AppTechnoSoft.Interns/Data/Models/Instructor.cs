using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTechnoSoft.Interns.Data.Models;
public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Organization { get; set; } = string.Empty;
    public string Resume { get; set; } = string.Empty;
    public string? ProfilePath { get; set; }
    public bool Publish { get; set; } = true;

    [NotMapped]
    public IBrowserFile? Profile { get; set; }

    public List<Tag>? Tags { get; set; } = [];

    public string? ApplicationUserId { get; set; }
    public ApplicationUser? User { get; set; }
}
