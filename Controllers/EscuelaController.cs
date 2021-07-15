using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVC.Controllers
{
    public class EscuelaController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}