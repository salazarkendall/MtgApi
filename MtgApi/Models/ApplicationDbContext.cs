using Microsoft.EntityFrameworkCore;

namespace MtgApi.Models;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<CardExample>();
  }

  // TODO: add DbSets
  public DbSet<CardExample> CardExamples => Set<CardExample>();
}