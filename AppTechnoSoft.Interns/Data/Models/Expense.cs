using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models;
public class Expense : BaseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public float Amount { get; set; }
    public ExpenseType ExpenseType { get; set; }
}
