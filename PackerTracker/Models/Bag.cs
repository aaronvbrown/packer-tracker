using System.Collections.Generic;
using System;



namespace PackerTracker.Models
{
  public class Bag
  {
    public List<Thing> suitCase = new List<Thing>();

    public void Pack(Thing thing)
    {
      thing.Packed = true;
      suitCase.Add(thing);
    }
  }
}