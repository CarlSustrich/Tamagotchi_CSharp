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
    public ActionResult Create()
    {

    }
  }
}