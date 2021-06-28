using Deliveryapi.Data;
using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.repo
{
    public class Executiveresrepo:Iexecutiveres
    {
        private readonly Customercontext _context;
        public Executiveresrepo()
        {

        }

        public Executiveresrepo(Customercontext _Context)
        {
            _context = _Context;
        }
        public Executiveres addnewexecutivereq(Executiveres p)
        {

            _context.Executiveres.Add(p);
            _context.SaveChanges();
            return p;

        }

        public void deleteexecutivereq(int id)
        {
            Executiveres p = _context.Executiveres.Find(id);
            _context.Executiveres.Remove(p);
            _context.SaveChanges();
        }

        public List<Executiveres> getexecutivereq()
        {
            return _context.Executiveres.ToList();
        }

        public Executiveres getexecutivereqbyid(int id)
        {
            return _context.Executiveres.Find(id);
        }

        public Executiveres updateexecutivereq(int id, Executiveres p)
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
                return _context.Executiveres.Any(e => e.ExrequestID == id);
            }
        }
    }
}
