using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller 
  {
    [HttpGet("/pets")]
    public ActionResult Index()
    {
      return View(Tamagotchi.Models.Pet.GetAll());
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet newPet = new Pet(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/pets/{id}")]
    public ActionResult Show(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }

    [Route("/FeedPet/{id}")]
    public ActionResult FeedPet(int id)
    {
      Pet targetPet = Pet.Find(id);
      targetPet.FoodIntake();
      return RedirectToAction("Show", targetPet);
      // return RedirectToAction("Show", Tamagotchi.Models.Pet.Find(id));
    }

    [HttpGet("/AttentionPet/{id}")]
    public ActionResult AttentionPet(int id)
    {
      Pet targetPet = Pet.Find(id);
      targetPet.AttentionHappy();
      return RedirectToAction("Show", targetPet);
    }
  }
}
