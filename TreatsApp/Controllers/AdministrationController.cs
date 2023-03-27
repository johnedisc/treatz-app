using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using TreatsApp.Models;
using System.Threading.Tasks;
using TreatsApp.ViewModels;

namespace TreatsApp.Controllers
{
  [Authorize(Roles = "Administrator")]
  public class AdministrationController : Controller
  {
    public IActionResult Index() =>
      Content("Administrator");
  }
}
