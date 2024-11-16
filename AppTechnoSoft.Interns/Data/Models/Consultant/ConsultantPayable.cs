using AppTechnoSoft.Interns.Data.Enums;

namespace AppTechnoSoft.Interns.Data.Models.Consultant;
public class ConsultantPayable
{
    public int Id { get; set; }
    public float? ConsultationFee { get; set; }
    public FundStatus Status { get; set; }
    public DateTime PaidDate { get; set; }

    public int ClassScheduleId { get; set; }
    public ClassSchedule? ClassSchedule { get; set; }
}
