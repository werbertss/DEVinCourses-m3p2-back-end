using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NDDTraining.Domain.Models;


namespace NDDTraining.Infra.Data.Context;

public class NDDTrainingDbContext : DbContext
{
  private readonly IConfiguration _configuration;

  public NDDTrainingDbContext(IConfiguration configuration)
  {
    _configuration = configuration;
  }

  public DbSet<Module> Modules { get; set; }
  public DbSet<Registration> Registrations { get; set; }
  public DbSet<Training> Trainings { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder options)
  {
    base.OnConfiguring(options);

    options.UseSqlServer(
        _configuration.GetConnectionString("NDDTraining")
    );
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    //modelBuilder.ApplyConfiguration(new TrainingMap());
    //modelBuilder.ApplyConfiguration(new RegistrationMap());
    //modelBuilder.ApplyConfiguration(new ModuleMap());

  }
}
