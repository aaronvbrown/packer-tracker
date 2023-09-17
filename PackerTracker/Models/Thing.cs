using System.Collections.Generic;
using System;

namespace PackerTracker.Models
{
  public class Thing
  {
    public int ID{get;}
    public string Description {get; set;}

    public int QuantityNeeded {get; set;}
    public bool Packed {get; set;}
    private static List<Thing> _toPack = new List<Thing> {};
    
    public Thing(string description, int quantity)
    {
      this.Description = description;
      this.QuantityNeeded = quantity;
      this.Packed = false;
      _toPack.Add(this);
      this.ID = _toPack.Count;
    }



    public static List<Thing> GetAll()
    {
      return _toPack;
    }
    public Thing Find(int searchID)
    {
      return _toPack[searchID-1];
    }
  }
}