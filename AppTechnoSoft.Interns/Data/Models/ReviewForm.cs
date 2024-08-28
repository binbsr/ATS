namespace AppTechnoSoft.Interns.Data.Models;

public class ReviewForm : BaseEntity
{
    public ReviewForm() => Id = Guid.NewGuid().ToString();

    public string Id { get; set; }
    public string Title { get; set; } = "";
    public DateTime? Expiration { get; set; }

    public int InstructorId { get; set; }
    public Instructor? Instructor { get; set; }

    public int TrainingId { get; set; }
    public Training? Training { get; set; }

    public List<ConsultantRating> ConsultantRatings { get; set; }
}
