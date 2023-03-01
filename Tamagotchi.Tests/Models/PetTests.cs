using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests : IDisposable
  {
    public void Dispose()
    {
      Pet.ClearAll();
    }

    [TestMethod]
    public void PetConstructor_CreateInstanceOfPet_Pet()
    {
      Pet newPet = new Pet("test name");
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "test Name";
      Pet newPet = new Pet(name);
      string result = newPet.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnId_Int()
    {
      string name = "test Name";
      Pet newPet = new Pet(name);
      int result = newPet.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnAllPetObjs_PetList()
    {
      //Arrange
      string name1 = "test Name1";
      string name2 = "test Name2";
      Pet newPet1 = new Pet(name1);
      Pet newPet2 = new Pet(name2);
      List<Pet> newList = new List<Pet>{newPet1, newPet2};
      //Act
      List<Pet> result = Pet.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnFindPetObjs_PetList()
    {
      //Arrange
      string name1 = "test Name1";
      string name2 = "test Name2";
      Pet newPet1 = new Pet(name1);
      Pet newPet2 = new Pet(name2);
      //Act
      Pet result = Pet.Find(2);
      //Assert
      Assert.AreEqual(newPet2, result);
    }
  } 
}
