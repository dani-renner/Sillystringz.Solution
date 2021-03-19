using Microsoft.AspNetCore.Mvc;
using Sillystringz.Models;
using System.Collections.Generic;

namespace Sillystringz.Controllers
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