using Microsoft.EntityFrameworkCore;

namespace UnitTestPractice;

public class AppDbContext : DbContext
{
    public DbSet<Animation> Animations { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animation>().HasKey(p => p.Id);
    }
    
}

public class Animation
{
    public int Id { get; set; }
    public string Name { get; set; }
}