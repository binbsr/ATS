namespace AppTechnoSoft.Interns.Data.Models;
public class FinAccount : BaseEntity
{
    public int Id { get; set; }
    public float FeeAmount { get; set; }
    public float Discount { get; set; } = 0.0f;
    public float PaidAmount { get; set; }
}
