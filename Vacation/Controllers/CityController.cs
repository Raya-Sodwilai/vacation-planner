using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Vacation.Models;
using Vacation.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Vacation.Controllers
{
  [Authorize]
  public class CityController : Controller
  {
    private readonly VacationContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public CityController(UserManager<ApplicationUser> userManager, VacationContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    public IActionResult Index()
    {
      var cityDatesViewModel = new CityViewModel();
      return View( cityDatesViewModel );
    }

    [HttpPost]
    public IActionResult AddCity( City CityName )
    {
      if (!ModelState.IsValid) return View();

      var city = CityName.Name;

      _db.City.Add( CityName );
      _db.SaveChanges();

            
      return RedirectToAction("Result", new {CityName.Name,CityName.Type});

    }

    [HttpGet]
    public IActionResult Result(CityViewModel results)
    {
    return View(results);
    }

    public IActionResult ViewCities()
    {
      IList<City> cities = _db.City.Include( c => c.Name ).ToList();

      return View( cities );
    }

        
    [HttpPost]
    public IActionResult RemoveCities(int [] cityIds)
    {
      foreach (int cityId in cityIds)
      {
        var theCity = _db.City.Single(c => c.ID == cityId);
        _db.City.Remove(theCity);
      }

      _db.SaveChanges();

      return RedirectToAction("ViewCities");
    }
  }
}