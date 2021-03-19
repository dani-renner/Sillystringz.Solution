using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}