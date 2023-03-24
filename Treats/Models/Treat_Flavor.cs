namespace TreatsApp.Models
{
  public class Treat_Flavor
    {       
        public int Treat_FlavorId { get; set; }
        public int TreatId { get; set; }
        public Treat Treat { get; set; }
        public int FlavorId { get; set; }
        public Flavor Flavor { get; set; }
    }
}

