namespace AppTechnoSoft.Interns.Data.Models;
public class Training : BaseEntity
{
    public int Id { get; set; }
    public float DurationHours { get; set; }
    public float DiscountPercentage { get; set; }

    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public int CourseQuoteId { get; set; }
    public CourseQuote? CourseQuote { get; set; }

    public int InstructorId { get; set; }
    public Instructor? Instructor { get; set; }
}
