using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Vacation.Models
{
  public class VacationContext : IdentityDbContext<ApplicationUser>
  {
    // public virtual DbSet<Event> Categories { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<Event> Events { get; set; }

    public VacationContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}