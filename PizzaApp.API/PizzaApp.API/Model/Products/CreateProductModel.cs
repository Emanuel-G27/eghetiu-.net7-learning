using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PizzaApp.API.Model.Products
{
    public class CreateProductModel : Controller
    {
        // GET: CreateProductModel
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreateProductModel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreateProductModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateProductModel/Create
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

        // GET: CreateProductModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreateProductModel/Edit/5
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

        // GET: CreateProductModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreateProductModel/Delete/5
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
