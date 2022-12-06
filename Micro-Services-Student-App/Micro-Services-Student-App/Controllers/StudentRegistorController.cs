using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Micro_Services_Student_App.Controllers
{
    public class StudentRegistorController : Controller
    {
        // GET: StudentRegistorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentRegistorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentRegistorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentRegistorController/Create
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

        // GET: StudentRegistorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentRegistorController/Edit/5
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

        // GET: StudentRegistorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentRegistorController/Delete/5
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
