using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Show()
    {
      List<Thing> Items = Thing.GetAll();
      return View(Items);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description, int quantity)
    {
      Thing toPack = new Thing(description, quantity);
      return RedirectToAction("Show");
    }
    
    //string description, int quantity
    //Thing toPack = new Thing(description, quantity);
    //RedirectToAction("Show")

    
  
 
  }
}