using System.Collections.Generic;

namespace TreatShop.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }
    public int TreatId { get;set; }
    public int Name { get;set; }
    public ICollection<TreatFlavor> Flavors { get;set; }
  }
}