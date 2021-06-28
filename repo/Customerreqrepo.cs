using Deliveryapi.Data;
using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.repo
{
    public class Customerreqrepo:Icustomerreq
    {
        private readonly Customercontext _context;
        public Customerreqrepo()
        {

        }

        public Customerreqrepo(Customercontext _Context)
        {
            _context = _Context;
        }
        public Userreq addnewcustomerreq(Userreq p)
        {

            _context.Userreq.Add(p);
            _context.SaveChanges();
            return p;

        }

        public void deletecustomerreq(int id)
        {
            Userreq p = _context.Userreq.Find(id);
            _context.Userreq.Remove(p);
            _context.SaveChanges();
        }

        public List<Userreq> getcustomerreq()
        {
            return _context.Userreq.ToList();
        }

        public Userreq getcustomerreqbyid(int id)
        {
            return _context.Userreq.Find(id);
        }

        public Userreq updatecustomerreq(int id, Userreq p)
        {
            _context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

            _context.Update(p);
            _context.SaveChanges();
            return p;
        }

        public bool customerreqexists(int id)
        {
            //private bool CustomerExists(int id)
            {
                return _context.Userreq.Any(e => e.RequestID == id);
            }
        }
    }
}
