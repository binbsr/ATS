using AppTechnoSoft.Interns.Data.Constants;
using AppTechnoSoft.Interns.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppTechnoSoft.Interns.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<College> Colleges { get; set; }
    public DbSet<TechProgram> TechPrograms { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<FinAccount> FinAccounts { get; set; }
    public DbSet<Widget> Widgets { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Batch> Batches { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Attendance> Attendances { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>().ToTable("Users");
        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRole");

        builder.Entity<Instructor>()
            .HasMany(e => e.Tags)
            .WithMany();

        builder.Entity<College>()
            .HasData([
                new College { Id = 1, Name = "Mechi Multiple Campus", Location = "Bhadrapur, Jhapa" },
                new College { Id = 2, Name = "Dhankuta Multiple Campus", Location = "Dhankuta" },
                new College { Id = 3, Name = "Central Campus of Technology", Location = "Dharan" },
                new College { Id = 4, Name = "Mahendra Morang Adarsha Multiple Campus", Location = "Biratnagar" },
                new College { Id = 5, Name = "Mahendra Bindeshwori Multiple Campus", Location = "Rajbiraj" },
                new College { Id = 6, Name = "Surya Narayan Satya Na. Mo. Yadav Campus", Location = "Siraha" },
                new College { Id = 7, Name = "Ramsorup Ramsagar Multiple Campus", Location = "Janakpur" },
                new College { Id = 8, Name = "Thakur Ram Multiple Campus", Location = "Birgunj" },
                new College { Id = 9, Name = "Birendra Multiple Campus", Location = "Bharatpur" },
                new College { Id = 10, Name = "Prithivi Narayan Multiple Campus", Location = "Pokhara" },
                new College { Id = 11, Name = "SidhaNath Science Campus", Location = "Mahendranagar" },
                new College { Id = 12, Name = "Mahendra Multiple Campus", Location = "Nepalgunj" },
                new College { Id = 13, Name = "Butwal Multiple Campus", Location = "Butwal" },
                new College { Id = 14, Name = "Tribhuvan Multiple Campus", Location = "Palpa" },
                new College { Id = 15, Name = "Tri-Chandra Multiple Campus", Location = "Ghantaghar" },
                new College { Id = 16, Name = "Amrit Science Campus", Location = "Lainchour" },
                new College { Id = 17, Name = "Patan Multiple Campus", Location = "Patan" },
                new College { Id = 18, Name = "Bhaktapur Multiple Campus", Location = "Bhaktapur" },
                new College { Id = 19, Name = "Padma Kanya Multiple Campus", Location = "Bagbazar" },
                new College { Id = 20, Name = "Mahendra Multiple Campus", Location = "Ghorahi, Dang" },
                new College { Id = 21, Name = "Dhaulagiri Campus", Location = "Baglung" },
                new College { Id = 22, Name = "Gorkha Campus", Location = "Gorkha" },
                new College { Id = 23, Name = "Bhairahawa Multiple Campus", Location = "Bhairahawa" },
                new College { Id = 24, Name = "Degree Campus", Location = "Biratnagar" }
        ]);

        builder.Entity<TechProgram>()
            .HasData([
                    new TechProgram { Id = 1, Name = "BCA", Affliation = "TU" },
                new TechProgram { Id = 2, Name = "BCA", Affliation = "PU" },
                new TechProgram { Id = 3, Name = "BIT", Affliation = "TU" },
                new TechProgram { Id = 4, Name = "BIT", Affliation = "PU" },
                new TechProgram { Id = 5, Name = "BIM", Affliation = "TU" },
                new TechProgram { Id = 6, Name = "BScIT", Affliation = "TU" },
                new TechProgram { Id = 7, Name = "BScIT", Affliation = "PU" },
            ]);


        builder.Entity<Widget>()
            .HasData([
                new Widget
                {
                    Id = 1,
                    Title = "CarouselItem",
                    Description = "An display item in home page",
                    HtmlContent = "Welcome to AppTechnoSoft! An initiative for students and freshers.",
                    Created = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Widget
                {
                    Id = 2,
                    Title = "CarouselItem",
                    Description = "An display item in home page",
                    HtmlContent = "Bridging the gap between academia and industry!",
                    Created = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Widget
                {
                    Id = 3,
                    Title = "CarouselItem",
                    Description = "An display item in home page",
                    HtmlContent = "We guide you on software R&D and SDLC to kickstart your career!",
                    Created = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Widget
                {
                    Id = 4,
                    Title = "CarouselItem",
                    Description = "An display item in home page",
                    HtmlContent = "Replacement Opportunities!",
                    Created = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Widget
                {
                    Id = 5,
                    Title = "CarouselItem",
                    Description = "An display item in home page",
                    HtmlContent = "From basics to professional touches!",
                    Created = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Widget
                {
                    Id = 6,
                    Title = "Module",
                    Description = "GIT and GitHub Essentials",
                    HtmlContent = "todo",
                    Created = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Widget
                {
                    Id = 7,
                    Title = "HomeIntro",
                    Description = "Training + Internship Combo",
                    HtmlContent = "todo",
                    Created = DateTime.Now,
                    CreatedBy = "Seed"
                }
            ]);

        // Seed roles and admin user
        string superAdminId = Guid.NewGuid().ToString();
        string superAdminRoleId = Guid.NewGuid().ToString();
        string adminRoleId = Guid.NewGuid().ToString();
        string traineeRoleId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>()
            .HasData([
                new IdentityRole
                {
                    Name = Role.SuperAdmin,
                    NormalizedName = "SUPERADMIN",
                    Id = superAdminRoleId,
                    ConcurrencyStamp = superAdminRoleId
                },
                new IdentityRole
                {
                    Name = Role.Admin,
                    NormalizedName = "ADMIN",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole
                {
                    Name = Role.Trainee,
                    NormalizedName = "TRAINEE",
                    Id = traineeRoleId,
                    ConcurrencyStamp = traineeRoleId
                }
            ]);

        var appUser = new ApplicationUser
        {
            Id = superAdminId,
            Email = "rawal.bishnu@live.com",
            EmailConfirmed = true,
            UserName = "rawal.bishnu@live.com",
            NormalizedUserName = "RAWAL.BISHNU@LIVE.COM"
        };

        //set user password
        PasswordHasher<ApplicationUser> ph = new();
        appUser.PasswordHash = ph.HashPassword(appUser, "~Someone1");

        builder.Entity<ApplicationUser>().HasData(appUser);

        builder.Entity<IdentityUserRole<string>>()
            .HasData([
                new IdentityUserRole<string>
                {
                    RoleId = superAdminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = traineeRoleId,
                    UserId = superAdminId
                }
            ]);
    }
}
