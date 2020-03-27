using System.Collections.Generic;

namespace TreatShop.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get;set; }
    public int Name { get;set; }
    public ICollection<TreatFlavor> Treats { get;set; }
  }
}