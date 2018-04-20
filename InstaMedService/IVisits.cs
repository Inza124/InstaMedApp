using System;
using System.Collections.Generic;
using System.Text;
using InstaMedData.Models;

namespace InstaMedService
{
    public interface IVisits
    {
        IEnumerable<Visit> GetAll();
        IEnumerable<Visit> GetAllWaiting();
        IEnumerable<Visit> GetAllFinalized();
        Visit GetById(int id);
        void SetStatus(Visit visit, string status);
        void Add(Visit one);
    }
}
