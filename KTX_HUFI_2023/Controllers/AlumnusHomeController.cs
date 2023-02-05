using Microsoft.AspNetCore.Mvc;

namespace KTX_HUFI_2023.Controllers
{
    public class AlumnusHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
