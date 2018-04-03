using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InstaMedApp.Models;
using InstaMedData.Models;
using InstaMedService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InstaMedApp.Controllers
{
    public class VisitController : Controller
    {
        private IVisits _visits;
        private ITests _tests;
        private UserManager<ApplicationUser> _user;
        private List<Test> cart;

        public VisitController(IVisits visits, ITests tests, UserManager<ApplicationUser> user)
        {
            cart = new List<Test>();
            _visits = visits;
            _tests = tests;
            _user = user;
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
            if (ModelState.IsValid)
            {
                Visit one = new Visit();
                one.Status = "Oczekująca";
                one.Tests = cart;
                one.dateTime = model.Date;
                one.User = _user.FindByIdAsync(_user.GetUserId(HttpContext.User)).Result;
                _visits.Add(one);

            }
            return RedirectToAction("Create");
        }

        public JsonResult AddToList(int id)
        {
            var currentTest = _tests.GetAll().FirstOrDefault(j => j.Id == id);
            cart.Add(currentTest);
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