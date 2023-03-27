using Microsoft.AspNetCore.Mvc;
using TreatsApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TreatsAppApp.Controllers
{
    public class HomeController : Controller
    {
      private readonly TreatsAppContext _db;
      private readonly UserManager<ApplicationUser> _userManager;

      public HomeController(UserManager<ApplicationUser> userManager, TreatsAppContext db)
      {
        _userManager = userManager;
        _db = db;
      }

      [Authorize(Roles="Administrator")]
      public ActionResult Admin()
      {
        List<Treat> allTreats = _db.Treats.ToList();
        List<Flavor> allFlavors = _db.Flavors.ToList();

        return View(new { treats = allTreats, flavors = allFlavors });
      }

      [HttpGet("/")]
      public async Task<ActionResult> Index()
      {
        string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        if (currentUser != null)
        {
          List<Treat> treats = _db.Treats
                      .Where(entry => entry.User.Id == currentUser.Id)
                      .ToList();
          return View(treats);
        }
        return View();
      }

    }
}
