using System;
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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InstaMedApp.Controllers
{
    public class ResultController : Controller
    {
        private IVisits _visits;
        private ITests _tests;
        private IResult _result;
        private UserManager<ApplicationUser> _user;
        private readonly IHostingEnvironment _appEnvironment;
        private ApplicationDbContext _context;
        public ResultController(IVisits visits, ITests tests, IResult result, IHostingEnvironment appEnvironment, ApplicationDbContext context, UserManager<ApplicationUser> user)
        {
            _user = user;
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

        public ActionResult GetAll()
        {
            var results = _result.GetAllResult().ToList();
            return View(results);
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
            var result = _context.Results.Include(h => h.TSHTest).FirstOrDefault(i => i.Id == id);
            int ID = result.TSHTest.Id;
            TSH TSHTest = _context.TSHs.Find(ID);
            return View(TSHTest);
        }

        public ActionResult T3T4Details(int id)
        {
            var result = _context.Results.Include(h => h.T3T4Test).FirstOrDefault(i => i.Id == id);
            int ID = result.T3T4Test.Id;
            T3T4 T3T4Test = _context.T3T4s.Find(ID);
            return View(T3T4Test);
        }

        public ActionResult GlukozaDetails(int id)
        {
            var result = _context.Results.Include(h => h.GlukozaTest).FirstOrDefault(i => i.Id == id);
            int ID = result.GlukozaTest.Id;
            Glukoza GlukozaTest = _context.Glukozas.Find(ID);
            return View(GlukozaTest);
        }

        public ActionResult OGTTDetails(int id)
        {
            var result = _context.Results.Include(h => h.OGTTTest).FirstOrDefault(i => i.Id == id);
            int ID = result.OGTTTest.Id;
            OGTT OGTTTest = _context.OGTTs.Find(ID);
            return View(OGTTTest);
        }

        public ActionResult MoczDetails(int id)
        {
            var result = _context.Results.Include(h => h.MoczTest).FirstOrDefault(i => i.Id == id);
            int ID = result.MoczTest.Id;
            Mocz MoczTest = _context.Moczs.Find(ID);
            return View(MoczTest);
        }

        public ActionResult SzpikDetails (int id)
        {
            var result = _context.Results.Include(h => h.SzpikTest).FirstOrDefault(i => i.Id == id);
            int ID = result.SzpikTest.Id;
            Szpik SzpikTest = _context.Szpiks.Find(ID);
            return View(SzpikTest);
        }

        public ActionResult KrzywaDetails(int id)
        {
            var result = _context.Results.Include(h => h.KrzywaTest).FirstOrDefault(i => i.Id == id);
            int ID = result.KrzywaTest.Id;
            Krzywa KrzywaTest = _context.Krzywas.Find(ID);
            return View(KrzywaTest);
        }

        public ActionResult BetaDetails(int id)
        {
            var result = _context.Results.Include(h => h.BetaHCGTest).FirstOrDefault(i => i.Id == id);
            int ID = result.BetaHCGTest.Id;
            BetaHCG BetaTest = _context.BetaHCGs.Find(ID);
            return View(BetaTest);
        }

        public ActionResult MorfDetails(int id)
        {
            var result = _context.Results.Include(h => h.MorfTest).FirstOrDefault(i => i.Id == id);
            int ID = result.MorfTest.Id;
            Morf MorfTest = _context.Morves.Find(ID);
            return View(MorfTest);
        }

        public ActionResult Morf5Details(int id)
        {
            var result = _context.Results.Include(h => h.Morf5Test).FirstOrDefault(i => i.Id == id);
            int ID = result.Morf5Test.Id;
            Morf5 Morf5Test = _context.Morves5.Find(ID);
            return View(Morf5Test);
        }

        public ActionResult TestosteronDetails(int id)
        {
            var result = _context.Results.Include(h => h.TestosteronTest).FirstOrDefault(i => i.Id == id);
            int ID = result.TestosteronTest.Id;
            Testosteron TestosteronTest = _context.Testosterons.Find(ID);
            return View(TestosteronTest);
        }

        public ActionResult ProgesteronDetails(int id)
        {
            var result = _context.Results.Include(h => h.ProgesteronTest).FirstOrDefault(i => i.Id == id);
            int ID = result.ProgesteronTest.Id;
            Progesteron ProgesteronTest = _context.Progesterons.Find(ID);
            return View(ProgesteronTest);
        }

        public ActionResult EstrogenDetails(int id)
        {
            var result = _context.Results.Include(h => h.EstrogenTest).FirstOrDefault(i => i.Id == id);
            int ID = result.EstrogenTest.Id;
            Estrogen EstrogenTest = _context.Estrogens.Find(ID);
            return View(EstrogenTest);
        }

        public ActionResult USGSzyiDetails(int id)
        {
            var result = _context.Results.Include(h => h.USGSzyiTest).FirstOrDefault(i => i.Id == id);
            int ID = result.USGSzyiTest.Id;
            USGSzyi USGSzyiTest = _context.USGSzyis.Find(ID);
            return View(USGSzyiTest);
        }

        public ActionResult USGSercaDetails(int id)
        {
            var result = _context.Results.Include(h => h.USGSercaTest).FirstOrDefault(i => i.Id == id);
            int ID = result.USGSercaTest.Id;
            USGSerca USGSercaTest = _context.USGSercas.Find(ID);
            return View(USGSercaTest);
        }

        public ActionResult USGPiersiDetails(int id)
        {
            var result = _context.Results.Include(h => h.USGPiersiTest).FirstOrDefault(i => i.Id == id);
            int ID = result.USGPiersiTest.Id;
            USGPiersi USGPiersiTest = _context.USGPiersis.Find(ID);
            return View(USGPiersiTest);
        }

        #endregion

        public ActionResult FindResult()
        {
            var userId = _user.GetUserId(HttpContext.User);
            ApplicationUser AppUser = _user.FindByIdAsync(userId).Result;
            var visits = _context.Visits.Where(h => h.User == AppUser);
            return View(visits);
        }

        public ActionResult SelectResult(int id)
        {
            var results = _result.GetResultsByVisit(_visits.GetById(id));
            return View(results);
        }

        public  IActionResult DetailsSelect(int id)
        {
            var model = _result.GetById(id);
            if (model.ResultType == "Badanie TSH") return RedirectToAction("TSHDetails", new { id });
            if (model.ResultType == "Badanie poziomu T3 i T4") return RedirectToAction("T3T4Details", new { id });
            if (model.ResultType == "Badanie obciążenia glukozy") return RedirectToAction("OGTTDetails", new { id });
            if (model.ResultType == "Badanie poziomu glukozy") return RedirectToAction("GlukozaDetails", new { id });
            if (model.ResultType == "Posiew moczu") return RedirectToAction("MoczDetails", new { id });
            if (model.ResultType == "Barwienie szpiku") return RedirectToAction("SzpikDetails", new { id });
            if (model.ResultType == "Krzywa cukrowa") return RedirectToAction("KrzywaDetails", new { id });
            if (model.ResultType == "Badanie poziomu testosteronu") return RedirectToAction("TestosteronDetails", new { id });
            if (model.ResultType == "Badanie poziomu progesteronu") return RedirectToAction("ProgesteronDetails", new { id });
            if (model.ResultType == "Badanie poziomu estrogenów") return RedirectToAction("EstrogenDetails", new { id });
            if (model.ResultType == "USG szyi") return RedirectToAction("USGSzyiDetails", new { id });
            if (model.ResultType == "USG serca") return RedirectToAction("USGSercaDetails", new { id });
            if (model.ResultType == "USG piersi") return RedirectToAction("USGPiersiDetails", new { id });
            if (model.ResultType == "Badanie hormonu BetaHCG") return RedirectToAction("BetaDetails", new { id });
            if (model.ResultType == "Morfologia krwi") return RedirectToAction("MorfDetails", new { id });
            if (model.ResultType == "Morfologia krwi z rozmazem") return RedirectToAction("Morf5Details", new { id });
            return View();
        }

        public IActionResult RedirectTo(TestTypeName nameString)
        {
            var model = new TestTypeName();
            return null;
        }
    }
}