using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
  public class RatingsController : Controller
  {


    public IActionResult Details(int id)
    {
      var thisPlace = Place.GetDetails(id);
      return View(thisPlace);
    }  
  }
}