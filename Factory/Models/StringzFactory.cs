using System.Collections.Generic;

namespace Factory.Models
{
  public class StringzFactory
  {
    public int StringzFactoryId { get; set; }
    public string Name { get; set; }

    public string Address { get; set; }
    public virtual ICollection<Engineer> Engineers { get; set; }
    public virtual ICollection<Machine> Machines { get; set; }

    public StringzFactory()
    {
      this.Engineers = new HashSet<Engineer>();
      this.Machines = new HashSet<Machine>();
    }
  }
}

