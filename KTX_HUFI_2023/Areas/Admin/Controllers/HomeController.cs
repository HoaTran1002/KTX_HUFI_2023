using Microsoft.AspNetCore.Mvc;

namespace KTX_HUFI_2023.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
