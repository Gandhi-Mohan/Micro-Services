using Micro_Services_Student_App.Models;
using Micro_Services_Student_App.StudentRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace Micro_Services_Student_App.Controllers
{
    public class StudentDataController : Controller
    {
        
        // GET: StudentDataController
       
        public ActionResult Index()
        {
           
            return View();
        }
      
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentDataController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentDataController/Create
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

        // GET: StudentDataController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentDataController/Edit/5
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

        // GET: StudentDataController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentDataController/Delete/5
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
