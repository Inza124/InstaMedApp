using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InstaMedApp.Models;
using InstaMedData.Models;
using InstaMedService;
using InstaMedApp.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InstaMedApp.Controllers
{
    public class VisitController : Controller
    {
        private IVisits _visits;
        private ITests _tests;
        private UserManager<ApplicationUser> _user;

        public VisitController(IVisits visits, ITests tests, UserManager<ApplicationUser> user)
        {
            _visits = visits;
            _tests = tests;
            _user = user;
        }

        public ActionResult Index()
        {
            var model = _visits.GetAll().ToList();
            return View(model);
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new VisitsViewModel();
            var testsList = _tests.GetAll();
            var userId = _user.GetUserId(HttpContext.User);
            ApplicationUser AppUser = _user.FindByIdAsync(userId).Result;
            ViewBag.User = AppUser;
            ViewBag.TestList = testsList;
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VisitsViewModel model)
        {
                model.Date = model.Date.ToUniversalTime();
                Visit one = new Visit();
                one.Status = "Oczekująca";
                one.TestsId = CartHelper.GetCart();
                one.dateTime = model.Date;
                one.User = _user.FindByIdAsync(_user.GetUserId(HttpContext.User)).Result;
                _visits.Add(one);
                CartHelper.ResetCart();
            
            return RedirectToAction("Create");
        }


        public ActionResult Realize(int id)
        {
            Visit visit = _visits.GetById(id);
            if (visit != null)
            {
                _visits.SetStatus(visit, "Zrealizowana");
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Archive(int id)
        {
            Visit visit = _visits.GetById(id);
            if (visit != null)
            {
                _visits.SetStatus(visit, "Zarchiwizowana");
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult BringBack(int id)
        {
            Visit visit = _visits.GetById(id);
            if (visit != null)
            {
                _visits.SetStatus(visit, "Oczekująca");
                return RedirectToAction("Index");
            }
            return View();
        }

        public JsonResult AddToList(int id)
        {
            var currentTest = _tests.GetAll().FirstOrDefault(j => j.Id == id);
            CartHelper.AddToCart(currentTest);
            return Json(currentTest);
        }

        public JsonResult Search(string request)
        {
            var testsList = _tests.GetAll().ToList();
            var newTestList = testsList.FindAll(x => x.Name.Contains(request));
            return Json(newTestList);
        }

        public ActionResult Succes()
        {
            return View();
        }
    }
}