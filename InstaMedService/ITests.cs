using System;
using InstaMedData.Models;
using System.Collections.Generic;
using System.Text;

namespace InstaMedService
{
    public interface ITests
    {
        IEnumerable<Test> GetAll();
        IEnumerable<TestTypeCategory> AllTypes();
        IEnumerable<TestTypeName> AllNames();
        TestTypeCategory GetCategoryById(int id);
        TestTypeName GetNameById(int id);
        IEnumerable<TestTypeName> AllNamesWithCat(int CategoryID);
        IEnumerable<String> TypeCategories();
        TestTypeName GetTestByName(String name);
        void Add(Test newTest);
    }
}
