using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TreatsApp.Models
{
  public class TreatsAppContext : IdentityDbContext<ApplicationUser>
  {

    public TreatsAppContext(DbContextOptions options) : base(options) { }
  }
}
