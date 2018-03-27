using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InstaMedService;
using InstaMedApp.Models;
using InstaMedData.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InstaMedApp.Controllers
{
    public class TestController : Controller
    {
        private ITests _tests;

        public TestController(ITests tests)
        {
            _tests = tests;
        }

        public IActionResult Index()
        {
            var model = _tests.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            var model = new TestsViewModel();
            var list = _tests.AllTypes().ToList();
            list.Insert(0,new TestTypeCategory(0, "Wybierz", 0));
            ViewBag.ListofCategory = list;

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(TestsViewModel model)
        {
            int intCatiD,intNameiD;
            var CatId = HttpContext.Request.Form["CategoryId"].ToString();
            var NameId = HttpContext.Request.Form["NameId"].ToString();
            Int32.TryParse(CatId,out intCatiD);
            Int32.TryParse(NameId, out intNameiD);

            if (ModelState.IsValid)
            {
                var test = new Test();
                test.Id = model.Id;
                test.Name = model.Name;
                test.Price = model.Price;
                test.testTypeCategory = _tests.GetCategoryById(intCatiD);
                test.testTypeName = _tests.GetNameById(intNameiD);
                _tests.Add(test);
            }
            var list = _tests.AllTypes().ToList();
            ViewBag.ListofCategory = list;
            return RedirectToAction("Index");
        }

        public JsonResult GetNames(int CategoryId)
        {
            var list = _tests.AllNamesWithCat(CategoryId);
            return Json(new SelectList(list, "NameId", "Name"));
        }

    }
}