using Microsoft.AspNetCore.Mvc;
using TreatsApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
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
