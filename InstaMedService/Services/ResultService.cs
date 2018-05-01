using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using InstaMedData.Models;
using InstaMedData;
using System.Linq;

namespace InstaMedService.Services
{
    public class ResultService : IResult
    {
        public ApplicationDbContext _context;
        public ITests _tests;
        public IVisits _visits;

        public ResultService(ApplicationDbContext context, ITests tests, IVisits visit)
        {
            _context = context;
            _tests = tests;
            _visits = visit;
        }
        public void Add(Result newResult)
        {
            _context.Add(newResult);
            _context.SaveChanges();
        }

        public Temp FindTempByTestId(int id)
        {
            return _context.Temps.FirstOrDefault(i => i.Id == id);
        }

        public Test FindTestByTempId(int id)
        {
            return _context.Tests.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Result> GetAllResult()
        {
            return _context.Results;
        }

        public Result GetById(int id)
        {
            return _context.Results.FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Result> GetResultsByTestType(TestTypeName ttName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Result> GetResultsByVisit(Visit newVisit)
        {
            return (from Result in _context.Results
                    where (Result.visit.Id == newVisit.Id)
                    select Result).ToList();
        }

        public IEnumerable<Test> GetTestsByVisit(Visit newVisit)
        {
            var visit = newVisit;
            var tests = visit.TestsId;
            var TestList = _tests.GetAll();
            var list = new List<Test>();
            foreach (Test value in TestList)
            {
                foreach (Temp test in tests)
                {
                    if (test.Id == value.Id)
                    {
                        list.Add(value);
                    }
                }
            }
            return list;
        }
    }
}
