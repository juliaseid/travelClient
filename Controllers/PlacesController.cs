using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
  public class PlacesController : Controller
  {
    public IActionResult Index()
    {
      var allPlaces = Place.GetPlaces();
      return View(allPlaces);
    }

    public IActionResult Details(int id)
    {
      var thisPlace = Place.GetDetails(id);
      var ratings = Rating.GetAll();
      ViewBag.Ratings = new List<Rating>{};
      foreach (Rating r in ratings) 
        {
          if (r.PlaceId == id)
          {
            ViewBag.Ratings.Add(r);
          }
        }
      return View(thisPlace);
    }  
  }
}