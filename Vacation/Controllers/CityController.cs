using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Vacation.Controllers
{
  public class CityController : Controller
  {
    private readonly VacationContext _db;
    [BindProperty]
    public City City { get; set; }
    public CityController(ApplicationDbContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Upsert(int? id)
    {
      City = new City();
      if (id == null)
      {
        return View(City);
      }

      City = _dbCities.FirstOrDefault(uint => uint.Id == id);
      if (City == null)
      {
        return NotFound();
      }
      return View(City);

    }
        
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Upsert()
    {
      if (ModelState.IsValid)
      {
        if (City.ID == 0)
        {
          _db.Cities.Add(City);
        }
        else
        {
          _db.Cities.Update(Book);
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(City);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      return Json(new { data = await _db.Cities.ToListAsync() });
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
      var cityFromDb = await _db.Cities.FirstOrDefaultAsync(u => u.Id == id);
      if (cityFromDb == null)
      {
        return Json(new { success = false, message = "Error while Deleting" });
      }
      _db.Cities.Remove(cityFromDb);
      await _db.SaveChangesAsync();
      return Json(new { success = true, message = "Delete successful" });
    }
  }
}