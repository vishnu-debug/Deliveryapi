using Deliveryapi.Data;
using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.repo
{
    public class Executiverepo:Iexecutive
    {

        private readonly Customercontext _context;
        public Executiverepo()
        {

        }

        public Executiverepo(Customercontext _Context)
        {
            _context = _Context;
        }
        public Executive addnewexecutive(Executive p)
        {

            _context.Executive.Add(p);
            _context.SaveChanges();
            return p;

        }

        public void deleteexecutive(int id)
        {
            Executive p = _context.Executive.Find(id);
            _context.Executive.Remove(p);
            _context.SaveChanges();
        }

        public List<Executive> getexecutive()
        {
            return _context.Executive.ToList();
        }

        public Executive getexecutivebyid(int id)
        {
            return _context.Executive.Find(id);
        }

        public Executive updateexecutive(int id, Executive p)
        {
            _context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

            _context.Update(p);
            _context.SaveChanges();
            return p;
        }

        public bool executiveexists(int id)
        {
            //private bool CustomerExists(int id)
            {
                return _context.Executive.Any(e => e.ExecutiveID == id);
            }
        }
    }
}
