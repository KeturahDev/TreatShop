using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using TreatShop.Models;

namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index(){return View();}
  }
}