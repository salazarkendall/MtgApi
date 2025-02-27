using Microsoft.EntityFrameworkCore;

namespace MtgApi.Models;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    // Cards_Colors: clase intermedia
    modelBuilder.Entity<Cards_Colors>()
      .HasKey(i => new { i.CardId, i.ColorId });

    modelBuilder.Entity<Cards_Colors>()
      .HasOne(e => e.Card)
      .WithMany(c => c.Cards_Colors)
      .HasForeignKey(k => k.CardId)
      .IsRequired()
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Cards_Colors>()
      .HasOne(e => e.Color)
      .WithMany(c => c.Cards_Colors)
      .HasForeignKey(k => k.ColorId)
      .IsRequired()
      .OnDelete(DeleteBehavior.Cascade);

    // Cards_Types: clase intermedia
    modelBuilder.Entity<Cards_Types>()
      .HasKey(i => new { i.CardId, i.TypeId });

    modelBuilder.Entity<Cards_Types>()
      .HasOne(e => e.Card)
      .WithMany(c => c.Cards_Types)
      .HasForeignKey(f => f.CardId)
      .IsRequired()
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Cards_Types>()
      .HasOne(e => e.Type)
      .WithMany(t => t.Cards_Types)
      .HasForeignKey(f => f.TypeId)
      .IsRequired()
      .OnDelete(DeleteBehavior.Cascade);

    // Cards_Subtypes: clase intermedia
    modelBuilder.Entity<Cards_Subtypes>()
      .HasKey(i => new { i.CardId, i.SubtypeId });

    modelBuilder.Entity<Cards_Subtypes>()
      .HasOne(e => e.Card)
      .WithMany(s => s.Cards_Subtypes)
      .HasForeignKey(f => f.CardId)
      .IsRequired()
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Cards_Subtypes>()
      .HasOne(e => e.Subtype)
      .WithMany(s => s.Cards_Subtypes)
      .HasForeignKey(f => f.SubtypeId)
      .IsRequired()
      .OnDelete(DeleteBehavior.Cascade);
  }

  // TODO: add DbSets
  public DbSet<Cards_Colors> Cards_Colors => Set<Cards_Colors>();
  public DbSet<Cards_Types> Cards_Types => Set<Cards_Types>();
  public DbSet<Cards_Subtypes> Cards_Subtypes => Set<Cards_Subtypes>();
  public DbSet<Card> Cards => Set<Card>();
  public DbSet<Color> Colors => Set<Color>();
  public DbSet<Type> Types => Set<Type>();
  public DbSet<Subtype> Subtypes => Set<Subtype>();
}