using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Persistence
{
  public class DataContext : IdentityDbContext<RingHonor>
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<RingHonor> RingHonor { get; set; }
    public DbSet<Players> Players { get; set; }
    public DbSet<Teams> Teams { get; set; }
  }
}