﻿using CubeRubik.Classes;
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

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Mix()
        {
            //List<int> yellow_side = new List<int>();
            //List<int> orange_side = new List<int>();
            //List<int> white_side = new List<int>();
            //List<int> red_side = new List<int>();
            //List<int> blue_side = new List<int>();
            //List<int> green_side = new List<int>();
            //Yellow yellow1 = new Yellow();
            //Orange orange = new Orange();
            //White white = new White();
            //Red red = new Red();
            //Blue blue = new Blue();
            //Green green = new Green();

            Cube cube = new Cube();
            cube.Side = new Side(1);
            //cube.Side._color = new Side.Color();
            //cube.Side._color
            //cube.Side.Rotate(1, new Red().layer.vLayer1);

            //for (int i=0; i<ONE_SIDE; i++)
            //{
            //    int yellow = new Random().Next(CUBE_PARTS);
            //    if(yellow >= 0 && yellow<9)
            //    {
            //        //yellow_side.Add(yellow);
                    
            //        yellow1.layer.points.Add(yellow);
            //    }
            //    if(yellow>=9 && yellow<18)
            //    {
            //        orange.layer.points.Add(yellow);
            //    }
            //    if(yellow>=18 && yellow<27)
            //    {
            //        //white_side.Add(yellow);
                    
            //        white.layer.points.Add(yellow);
            //    }
            //    if (yellow >= 27 && yellow < 36)
            //    {
            //        //red_side.Add(yellow);
                    
            //        red.layer.points.Add(yellow);
            //    }
            //    if (yellow >= 36 && yellow < 45)
            //    {
            //        //blue_side.Add(yellow);
                    
            //        blue.layer.points.Add(yellow);
            //    }
            //    if (yellow >= 45 && yellow < 54)
            //    {
            //        //green_side.Add(yellow);
                    
            //        green.layer.points.Add(yellow);
            //    }
            //}

            return View();
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
