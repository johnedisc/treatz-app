using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreatsApp.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "provide a flavor name")]
    public string Name { get; set; }
    public List<Treat_Flavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}

