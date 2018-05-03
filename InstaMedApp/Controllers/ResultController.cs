﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaMedData.Models;
using InstaMedData;
using InstaMedApp.Models;
using System.Dynamic;
using InstaMedService;
using Microsoft.AspNetCore.Mvc;
using InstaMedApp.Extensions;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace InstaMedApp.Controllers
{
    public class ResultController : Controller
    {
        private IVisits _visits;
        private ITests _tests;
        private IResult _result;
        private readonly IHostingEnvironment _appEnvironment;
        private ApplicationDbContext _context;
        public ResultController(IVisits visits, ITests tests, IResult result, IHostingEnvironment appEnvironment, ApplicationDbContext context)
        {
            _visits = visits;
            _tests = tests;
            _result = result;
            _context = context;
            _appEnvironment = appEnvironment;
        }

        public ActionResult Create(int id)
        {
            var test = _result.FindTestByTempId(id);
            if (id == 0)
            {
                return RedirectToAction("SmfGoesWrong");
            }
            if (test.Name == "Badanie TSH")
            {
                return RedirectToAction("TSH");
            }
            if (test.Name == "Badanie poziomu T3 i T4")
            {
                return RedirectToAction("T3T4");
            }
            if (test.Name == "Badanie obciążenia glukozy")
            {
                return RedirectToAction("OGTT");
            }
            if (test.Name == "Badanie poziomu glukozy")
            {
                return RedirectToAction("Glukoza");
            }
            if (test.Name == "Krzywa cukrowa")
            {
                return RedirectToAction("Krzywa");
            }
            if (test.Name == "Badanie poziomu testosteronu")
            {
                return RedirectToAction("Testosteron");
            }
            if (test.Name == "Badanie poziomu progesteronu")
            {
                return RedirectToAction("Progesteron");
            }
            if (test.Name == "Badanie poziomu estrogenów")
            {
                return RedirectToAction("Estrogeny");
            }
            if (test.Name == "Badanie hormonu BetaHCG")
            {
                return RedirectToAction("Beta");
            }
            if (test.Name == "USG serca")
            {
                return RedirectToAction("Usgse");
            }
            if (test.Name == "USG piersi")
            {
                return RedirectToAction("Usgpi");
            }
            if (test.Name == "USG szyi")
            {
                return RedirectToAction("Usgsz");
            }
            if (test.Name == "Morfologia krwi")
            {
                return RedirectToAction("Morf");
            }
            if (test.Name == "Morfologia krwi z rozmazem")
            {
                return RedirectToAction("Morfz");
            }
            if (test.Name == "Barwienie szpiku")
            {
                return RedirectToAction("Szpik");
            }
            if (test.Name == "Posiew moczu")
            {
                return RedirectToAction("Mocz");
            }
            return RedirectToAction("ChooseRes");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChooseRes(int id)
        {
            var currentVisit = _visits.GetById(id);
            ViewBag.Result = _result.GetResultsByVisit(currentVisit);

            var currentVisitTests = _result.GetTestsByVisit(currentVisit);
            CartHelper.SetVisitId(currentVisit.Id);
            return View(currentVisitTests);
        }

        #region Create Methods 

        public ActionResult OGTT(int id)
        {
            var model = new OGTT { isOGTT = false };
            return View(model);
        }

        public ActionResult Glukoza(int id)
        {
            var model = new Glukoza { isGlukoza = false };
            return View(model);
        }

        public ActionResult Krzywa(int id)
        {
            var model = new Krzywa { isKrzywa = false };
            return View(model);
        }

        public ActionResult Testosteron(int id)
        {
            var model = new Testosteron { isTestosteron = false };
            return View(model);
        }

        public ActionResult Progesteron(int id)
        {
            var model = new Progesteron { isProgesteron = false };
            return View(model);
        }

        public ActionResult Estrogeny(int id)
        {
            var model = new Estrogen { isEstrogen = false };
            return View(model);
        }

        public ActionResult Beta(int id)
        {
            var model = new BetaHCG { isBeta = false };
            return View(model);
        }

        public ActionResult Usgse(int id)
        {
            var model = new USGSerca { isUSGSerca = false };
            return View(model);
        }

        public ActionResult Usgpi(int id)
        {
            var model = new USGPiersi { isUSGPiersi = false };
            return View(model);
        }

        public ActionResult Usgsz(int id)
        {
            var model = new USGSzyi { isUSGSzyi = false };
            return View(model);
        }

        public ActionResult Morf(int id)
        {
            var model = new Morf { isMorf = false };
            return View(model);
        }

        public ActionResult Morfz(int id)
        {
            var model = new Morf5 { isMorf5 = false };
            return View(model);
        }

        public ActionResult Mocz(int id)
        {
            var model = new Mocz { isMocz = false };
            return View(model);
        }

        public ActionResult Szpik(int id)
        {
            var model = new Szpik { isSzpik = false };
            return View(model);
        }

        public ActionResult TSH(int id)
        {
            var model = new TSH { isTSH = false };
            return View(model);
        }

        public ActionResult T3T4(int id)
        {
            var model = new T3T4 { isT3T4 = false };
            return View(model);
        }

        #endregion

        #region AddToDatabase  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TSH model_TSH, T3T4 model_T3T4, Mocz model_Mocz, Szpik model_Szpik, BetaHCG model_HCG,
                                   Krzywa model_Krzywa, OGTT model_OGTT, Glukoza model_Glukoza, Morf model_Morf, Morf5 model_Morf5,
                                   Progesteron model_Progesteron, Testosteron model_Testosteron, Estrogen model_Estrogen,
                                   USGPiersi model_Piersi, USGSerca model_Serca, USGSzyi model_Szyi)
        {
            Result one = new Result();
            if (ModelState.IsValid)
            {
                if (model_TSH.isTSH == true)
                {
                    one.DoctorName = model_TSH.DocName;
                    one.TSHTest = model_TSH;
                    one.ResultType = "Badanie TSH";
                }

                if (model_Glukoza.isGlukoza == true)
                {
                    one.DoctorName = model_Glukoza.DocName;
                    one.GlukozaTest = model_Glukoza;
                    one.ResultType = "Badanie poziomu glukozy";
                }

                if (model_Mocz.isMocz == true)
                {
                    one.DoctorName = model_Mocz.DocName;
                    one.MoczTest = model_Mocz;
                    one.ResultType = "Posiew moczu";
                }

                if (model_Szpik.isSzpik == true)
                {
                    one.DoctorName = model_Szpik.DocName;
                    one.SzpikTest = model_Szpik;
                    one.ResultType = "Barwienie szpiku";
                }


                if (model_HCG.isBeta == true)
                {
                    one.DoctorName = model_HCG.DocName;
                    one.BetaHCGTest = model_HCG;
                    one.ResultType = "Badanie hormonu BetaHCG";
                }

                if (model_Krzywa.isKrzywa == true)
                {
                    one.DoctorName = model_Krzywa.DocName;
                    one.KrzywaTest = model_Krzywa;
                    one.ResultType = "Krzywa cukrowa";
                }

                if (model_OGTT.isOGTT == true)
                {
                    one.DoctorName = model_OGTT.DocName;
                    one.OGTTTest = model_OGTT;
                    one.ResultType = "Badanie obciążenia glukozy";
                }

                if (model_Morf.isMorf == true)
                {
                    one.DoctorName = model_Morf.DocName;
                    one.MorfTest = model_Morf;
                    one.ResultType = "Morfologia krwi";
                }

                if (model_Morf5.isMorf5 == true)
                {
                    one.DoctorName = model_Morf5.DocName;
                    one.Morf5Test = model_Morf5;
                    one.ResultType = "Morfologia krwi z rozmazem";
                }

                if (model_Progesteron.isProgesteron == true)
                {
                    one.DoctorName = model_Progesteron.DocName;
                    one.ProgesteronTest = model_Progesteron;
                    one.ResultType = "Badanie poziomu progesteronu";
                }

                if (model_Estrogen.isEstrogen == true)
                {
                    one.DoctorName = model_Estrogen.DocName;
                    one.EstrogenTest = model_Estrogen;
                    one.ResultType = "Badanie poziomu estrogenów";
                }

                if (model_Testosteron.isTestosteron == true)
                {
                    one.DoctorName = model_Testosteron.DocName;
                    one.TestosteronTest = model_Testosteron;
                    one.ResultType = "Badanie poziomu testosteronu";
                }

                if (model_Serca.isUSGSerca == true)
                {
                    one.DoctorName = model_Serca.DocName;

                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {
                            var file = Image;
                            var uploads = Path.Combine(_appEnvironment.WebRootPath, "uploads\\img");
                            if (file.Length > 0)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    file.CopyTo(fileStream);
                                    model_Serca.ImageName = fileName;
                                }

                            }
                        }
                    }
                    one.USGSercaTest = model_Serca;
                    one.ResultType = "USG serca";
                }

                if (model_Piersi.isUSGPiersi == true)
                {
                    one.DoctorName = model_Piersi.DocName;

                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {
                            var file = Image;
                            var uploads = Path.Combine(_appEnvironment.WebRootPath, "uploads\\img");
                            if (file.Length > 0)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    file.CopyTo(fileStream);
                                    model_Piersi.ImageName = fileName;
                                }

                            }
                        }
                    }
                    one.USGPiersiTest = model_Piersi;
                    one.ResultType = "USG piersi";
                }


                if (model_Szyi.isUSGSzyi == true)
                {
                    one.DoctorName = model_Szyi.DocName;

                    var files = HttpContext.Request.Form.Files;
                    foreach (var Image in files)
                    {
                        if (Image != null && Image.Length > 0)
                        {
                            var file = Image;
                            var uploads = Path.Combine(_appEnvironment.WebRootPath, "uploads\\img");
                            if (file.Length > 0)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    file.CopyTo(fileStream);
                                    model_Szyi.ImageName = fileName;
                                }

                            }
                        }
                    }
                    one.USGSzyiTest = model_Szyi;
                    one.ResultType = "USG szyi";
                }

                if (model_T3T4.isT3T4 == true)
                {
                    one.DoctorName = model_T3T4.DocName;
                    one.T3T4Test = model_T3T4;
                    one.ResultType = "Badanie poziomu T3 i T4";
                }
                one.visit = _visits.GetById(CartHelper.GetVisitId());
                _result.Add(one);
            }
            return RedirectToAction("ChooseRes", new { id = one.visit.Id });
        }
        #endregion

        #region Details Methods

        public ActionResult TSHDetails(int id)
        {
            TSH TSHTest = _context.TSHs.Find(id);
            return View(TSHTest);
        }

        public ActionResult T3T4Details(int id)
        {
            T3T4 T3T4Test = _context.T3T4s.Find(id);
            return View(T3T4Test);
        }

        public ActionResult GlukozaDetails(int id)
        {
            Glukoza GlukozaTest = _context.Glukozas.Find(id);
            return View(GlukozaTest);
        }

        public ActionResult OGTTDetails(int id)
        {
            OGTT OGTTTest = _context.OGTTs.Find(id);
            return View(OGTTTest);
        }

        public ActionResult MoczDetails(int id)
        {
            Mocz MoczTest = _context.Moczs.Find(id);
            return View(MoczTest);
        }

        public ActionResult SzpikDetails (int id)
        {
            Szpik SzpikTest = _context.Szpiks.Find(id);
            return View(SzpikTest);
        }

        public ActionResult KrzywaDetails(int id)
        {
            Krzywa KrzywaTest = _context.Krzywas.Find(id);
            return View(KrzywaTest);
        }

        public ActionResult BetaDetails(int id)
        {
            BetaHCG BetaTest = _context.BetaHCGs.Find(id);
            return View(BetaTest);
        }

        #endregion

        public IActionResult RedirectTo(TestTypeName nameString)
        {
            var model = new TestTypeName();
            return null;
        }
    }
}