using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Vacation.Models
{
  public class VacationContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<City> City { get; set; }
    public DbSet<Event> Events { get; set; }

    public VacationContext(DbContextOptions<VacationContext> options) 
      : base(options) 
      { 
      }
      
  }
}