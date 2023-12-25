using AppTechnoSoft.Interns.Data.Models;
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

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
                    new TechProgram { Id = 1,  Name="BCA", Affliation="TU" },
                    new TechProgram { Id = 2,  Name="BCA", Affliation="PU" },
                    new TechProgram { Id = 3,  Name="BIT", Affliation="TU" },
                    new TechProgram { Id = 4,  Name="BIT", Affliation="PU" },
                    new TechProgram { Id = 5,  Name="BIM", Affliation="TU" },
                    new TechProgram { Id = 6,  Name="BScIT", Affliation="TU" },
                    new TechProgram { Id = 7,  Name="BScIT", Affliation="PU" },
            ]);
    }
}
