using System;
using System.Collections.Generic;
using System.Text;
using InstaMedData;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using InstaMedData.Models;

namespace InstaMedService.Services
{
    public class TestsService : ITests
    {
        private ApplicationDbContext _context;

        public TestsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TestTypeCategory> AllTypes()
        {
            return _context.TestTypeCategories;
        }

        public IEnumerable<TestTypeName> AllNames()
        {
            return _context.TestTypeNames;
        }

        public IEnumerable<TestTypeName> AllNamesWithCat(int CategoryId)
        {
            return (from TestTypeName in _context.TestTypeNames
                    where (TestTypeName.CategoryId == CategoryId)
                    select TestTypeName).ToList();
        }

        public IEnumerable<Test> GetAll()
        {
            return _context.Tests
                .Include(h => h.testTypeCategory)
                .Include(h => h.testTypeName);
        }

        public void Add(Test newTest)
        {
            _context.Add(newTest);
            _context.SaveChanges();
        }

        public TestTypeName GetTestByName(String name)
        {
            return _context.TestTypeNames.FirstOrDefault(h => h.Name == name);
        }

        public IEnumerable<string> TypeCategories()
        {
            return _context.TestTypeCategories.Select(x => x.Category).Distinct().ToList();
        }

        public TestTypeCategory GetCategoryById(int id)
        {
            return AllTypes().FirstOrDefault(catID => catID.CategoryId == id);
        }

        public TestTypeName GetNameById(int id)
        {
            return AllNames().FirstOrDefault(name => name.NameId == id);
        }

        public Test GetTestById(int id)
        {
            return _context.Tests.FirstOrDefault(i => i.Id == id);
        }
    }
}
