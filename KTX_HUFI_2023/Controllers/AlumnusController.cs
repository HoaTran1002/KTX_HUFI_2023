using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTX_HUFI_2023.Controllers
{
    public class AlumnusController : Controller
    {
        // GET: AlumnusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AlumnusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AlumnusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlumnusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AlumnusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlumnusController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
