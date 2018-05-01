using InstaMedData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InstaMedService
{
    public interface IResult
    {
        void Add(Result newResult);
        Result GetById(int id);
        Temp FindTempByTestId(int id);
        Test FindTestByTempId(int id);
        IEnumerable<Test> GetTestsByVisit(Visit newVisit);
        IEnumerable<Result> GetAllResult();
        IEnumerable<Result> GetResultsByVisit(Visit newVisit);
        IEnumerable<Result> GetResultsByTestType(TestTypeName ttName);
    } 
}
