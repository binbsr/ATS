using AppTechnoSoft.Interns.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTechnoSoft.Interns.Data.Models;
public class Batch: BaseEntity
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    [NotMapped]
    public string Name => $"{"Batch".MakeUnique()} - {Start:MMM dd (yyyy)} to {End:MMM dd (yyyy)}";
}
