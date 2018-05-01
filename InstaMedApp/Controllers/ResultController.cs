﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaMedData.Models;
using InstaMedApp.Models;
using System.Dynamic;
using InstaMedService;
using Microsoft.AspNetCore.Mvc;
using InstaMedApp.Extensions;

namespace InstaMedApp.Controllers
{
    public class ResultController : Controller
    {
        private IVisits _visits;
        private ITests _tests;
        private IResult _result;
        private Visit VisitBackup;
        public ResultController(IVisits visits, ITests tests, IResult result)
        {
            _visits = visits;
            _tests = tests;
            _result = result;
        }

        public IActionResult Create(int id)
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
            return RedirectToAction("ChooseRes");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChooseRes(int id)
        {
            var currentVisit = _visits.GetById(id);
            var currentVisitTests = _result.GetTestsByVisit(currentVisit);
            CartHelper.SetVisitId(currentVisit.Id);
            return View(currentVisitTests);
        }

        public ActionResult TSH(int id)
        {
             var model = new TSH();
             return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TSH model_TSH, T3T4 model_T3T4)
        {
            if (ModelState.IsValid)
            {
                Result one = new Result();

                if (model_TSH.Type == "TSH")
                {
                    one.DoctorName = model_TSH.DocName;
                    one.TSHTest = model_TSH;
                }

                if (model_T3T4.Type == "T3T4")
                {
                    one.DoctorName = model_T3T4.DocName;
                    one.T3T4Test = model_T3T4;
                }
                one.visit = _visits.GetById(CartHelper.GetVisitId());
                _result.Add(one);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RedirectTo(TestTypeName nameString)
        {
            var model = new TestTypeName();
            return null;
        }
    }
}