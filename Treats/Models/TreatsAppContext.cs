using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TreatsApp.Models
{
  public class TreatsAppContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat_Flavor> Treat_Flavors { get; set; }

    public TreatsAppContext(DbContextOptions options) : base(options) { }
  }
}

