using Microsoft.AspNetCore.Mvc;
using TreatsAppApp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TreatsAppApp.Controllers
{
    public class HomeController : Controller
    {
      private readonly TreatsAppAppContext _db;
      private readonly UserManager<ApplicationUser> _userManager;

      public HomeController(UserManager<ApplicationUser> userManager, TreatsAppAppContext db)
      {
        _userManager = userManager;
        _db = db;
      }

    }
}
