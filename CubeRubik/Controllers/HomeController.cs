using CubeRubik.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CubeRubik.Controllers
{
    public class HomeController : Controller
    {
        public const int CUBE_PARTS = 54;
        public const int ONE_SIDE = 9;

        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Init()
        {
            Cube cube = new();
            return Json(cube);
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        /*
        /-Horizontal Layer 3-/
        /-Horizontal Layer 2-/
        /-Horizontal Layer 1-/
        */

        public IActionResult Mix(Cube cube)
        {
            //Cube cube = new Cube();
            cube.Rotate(Layer.TypeLayer.V3, Side.Direction.UP, 1);

            return Json(cube);
            //return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
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

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
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

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
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
