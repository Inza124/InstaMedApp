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
        void Add(Visit one);
    }
}
