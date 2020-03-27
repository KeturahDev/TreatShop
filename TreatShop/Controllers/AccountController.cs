using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using TreatShop.Models;
using System.Threading.Tasks;
using TreatShop.ViewModels;

namespace TreatShop.Controllers
{
  public class AccountController : Controller
  {
    private readonly TreatShopContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, TreatShopContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }
  }
}