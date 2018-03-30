using System;
using System.Collections.Generic;
using System.Text;
using InstaMedData.Models;

namespace InstaMedService
{
    public interface IVisits
    {
        IEnumerable<Visit> GetAll();
        Visit GetById(int id);
        void Add(Visit one);
    }
}
