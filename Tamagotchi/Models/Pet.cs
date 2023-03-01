using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
      Food = 10;
      Attention = 10;
      Sleep = 10;
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

    public void FoodIntake()
    {
      if (Food+10 <= 100)
      {
        Food += 10;
      }
      else
      {
        Food = 100;
      }
    }

    public void AttentionHappy()
    {
      if (Attention+10 <= 100)
      {
        Attention += 10;
      }
      else 
      {
        Attention = 100;
      }
    }

    // public static void DecrementOverTime()
    // {
    //   Task.Delay(3000).Wait();
    //   List<Pet> list = Pet.GetAll();
    //   foreach (Pet pet in list)
    //   {
    //     pet.Attention -= 10;
    //     pet.Food -=10;
    //     pet.Sleep -=10;
    //   }
    //   Pet.DecrementOverTime();
    // }
  }
}
