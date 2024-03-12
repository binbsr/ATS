namespace AppTechnoSoft.Interns.Data.Constants;
public class Role
{
    public const string Admin = nameof(Admin);
    public const string Instructor = nameof(Instructor);
    public const string SuperAdmin = nameof(SuperAdmin);
    public const string Trainee = nameof(Trainee);
    public const string Employee = nameof(Employee);
    public const string Admins = $"{Admin},{SuperAdmin}";
}
