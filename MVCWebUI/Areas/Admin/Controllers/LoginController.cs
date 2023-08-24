using Microsoft.AspNetCore.Mvc;

namespace MVCWebUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
