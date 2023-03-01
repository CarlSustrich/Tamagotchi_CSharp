using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public string Name {get;set;}
    public int Id {get;}
    public int Food {get;set;}
    public int Attention {get;set;}
    public int Sleep {get;set;}
    private static List<Pet> _instances = new List<Pet> {};

    public Pet(string name)
    {
      Name = name;
      Food = 100;
      Attention = 100;
      Sleep = 100;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Pet> GetAll()
    {
      return _instances;
    }

    public static Pet Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
