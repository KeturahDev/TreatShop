using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using TreatShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;


namespace TreatShop.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly TreatShopContext _db;

    public FlavorsController(TreatShopContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
    
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Flavor thisFlavor = _db.Flavors
        .Include(flavor => flavor.Treats)
        .ThenInclude(join => join.Treat)
        .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    public ActionResult Edit(int id)
    {
      Flavor thisFlavor = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }

    [HttpPost]
    public ActionResult Edit(Flavor flavor)
    {
      _db.Entry(flavor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddTreat(int id)
    {
      Flavor flavorToAddTreatTo = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View(flavorToAddTreatTo);
    }

    [HttpPost]
    public ActionResult AddTreat(Flavor flavor, int TreatId)
    {
      if(TreatId != 0)
      {
        _db.TreatFlavor.Add(new TreatFlavor {TreatId = TreatId, FlavorId = flavor.FlavorId});
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = flavor.FlavorId});
    }

    public ActionResult Delete(int id)
    {
      Flavor flavorToDelete = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(flavorToDelete);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirm(int id)
    {
      Flavor flavorToDelete = _db.Flavors.FirstOrDefault(flavor => flavor.FlavorId == id);
      _db.Flavors.Remove(flavorToDelete);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}


    // private readonly TreatShopContext _db;
    // private readonly UserManager<ApplicationUser> _userManager;

    // public FlavorsController(UserManager<ApplicationUser> userManager,TreatShopContext db)
    // {
    //   _userManager = userManager;
    //   _db = db;
    // }

    // [HttpPost]
    // public async Task<ActionResult> Create(Flavor flavor)
    // {
    //   var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   // var currentUser = await _userManager.FindByIdAsync(userId);
    //   // flavor.User = currentUser;
    //   _db.Flavors.Add(flavor);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }


// public ActionResult Details(int id)
//     {
//       Flavor thisFlavor = _db.Flavors
//         .Include(flavor => flavor.Treats)
//         .ThenInclude(join => join.Treat)
//         .FirstOrDefault(flavor => flavor.FlavorId == id);

//       // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//       // ViewBag.IsCurrentUser = userId == thisFlavor.User.Id; //doesnt have access to user Id ? line doesnt work
//       return View(thisFlavor);
//     }

// [Authorize]
    // public async Task<ActionResult> Edit(int id)
    // {
      // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      // var currentUser = await _userManager.FindByIdAsync(userId);
      // Flavor thisFlavor = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id).FirstOrDefault(flavor => flavor.FlavorId == id);
      // if (thisFlavor == null)
      // {
      //   return RedirectToAction("Details", new {id = id});
      // }
      // else
      // {
      //   return View(thisFlavor);
      // }
    // }