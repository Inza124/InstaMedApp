using System;
using System.Collections.Generic;
using System.Text;
using InstaMedData;
using InstaMedData.Models;
using Microsoft.EntityFrameworkCore;

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
            throw new NotImplementedException();
        }

        public Visit GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
