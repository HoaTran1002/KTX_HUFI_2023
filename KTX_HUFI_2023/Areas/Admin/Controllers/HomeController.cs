using Microsoft.AspNetCore.Mvc;

namespace KTX_HUFI_2023.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
