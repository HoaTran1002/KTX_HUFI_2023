using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTX_HUFI_2023.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
