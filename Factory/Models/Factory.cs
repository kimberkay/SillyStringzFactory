using System.Collections.Generic;

namespace Factory.Models
{
  public class Factory
  {
    public int FactoryId { get; set; }
    public string Name { get; set; }

    public string Address
    public virtual ICollection<Engineer> Engineers { get; set; }
    public virtual ICollection<Machine> Machines { get; set; }

    public Factory()
    {
      this.Engineers = new HashSet<Engineer>();
      this.Machines = new HashSet<Machine>();
    }
  }
}

