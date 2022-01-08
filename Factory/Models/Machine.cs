using System.Collections.Generic;
using System;


namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new Hashet<EngineerMachine>();
      this.InOperation = false;
    }

    public int MachineId { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public bool InOperation { get; set; }

    public DateTime LastInspection { get; set; }

    public DateTime DateOfLastMaintenance  { get; set; }

    
    public virtual Factory {get; set; }

    public int FactoryId { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}