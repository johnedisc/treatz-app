using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreatsApp.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "provide a description")]
    public string Description { get; set; }
    [Required(ErrorMessage = "provide a Name")]
    public string Name { get; set; }
    public List<Treat_Flavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}

