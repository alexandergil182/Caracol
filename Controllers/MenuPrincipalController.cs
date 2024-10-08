using Microsoft.AspNetCore.Mvc;

namespace CaracolTanqueos.Controllers
{
    public class MenuPrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
