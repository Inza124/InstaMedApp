using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InstaMedApp.Models;
using InstaMedService;

namespace InstaMedApp.Controllers
{
    public class VisitController : Controller
    {
        private IVisits _visits;
        private ITests _tests;

        public VisitController(IVisits visits, ITests tests)
        {
            _visits = visits;
            _tests = tests;
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new VisitsViewModel();
            var testsList = _tests.GetAll();
            ViewBag.TestList = testsList;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VisitsViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return RedirectToAction("Succes");
        }

        
        public ActionResult Edit(int id)
        {
            return View();
        }


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


        public ActionResult Delete(int id)
        {
            return View();
        }


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

        public ActionResult Succes()
        {
            return View();
        }
    }
}