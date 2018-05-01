using System;
using System.Collections.Generic;
using System.Text;
using InstaMedData;
using InstaMedData.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InstaMedService.Services
{
    public class VisitsService : IVisits
    {
        public ApplicationDbContext _context;

        public VisitsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Visit one)
        {
            _context.Add(one);
            _context.SaveChanges();
        }

        public IEnumerable<Visit> GetAll()
        {
            return _context.Visits
                .Include(h => h.User)
                .Include(i => i.TestsId);
        }

        public IEnumerable<Visit> GetAllFinalized()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visit> GetAllWaiting()
        {
            return (from vis in _context.Visits where vis.Status=="Oczekująca" select vis).Include(h => h.User);
        }

        public Visit GetById(int id)
        {
            return GetAll().FirstOrDefault(h => h.Id == id);
        }

        public void SetStatus(Visit visit, string status)
        {
            var model = visit;
            model.Status = status;
            _context.Entry(visit).CurrentValues.SetValues(model);
            _context.SaveChanges();
        }
    }
}
