using Deliveryapi.Data;
using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.repo
{
    public class customerrepo : Icustomer
    {
        private readonly Customercontext _context;
        public customerrepo()
        {

        }

        public customerrepo(Customercontext _Context)
        {
            _context = _Context;
        }
        public bool addnewcustomer(Customer p)
        {

            _context.Customer.Add(p);
            _context.SaveChanges();
            return true;

        }

        public bool deletecustomer(int id)
        {
            Customer p = _context.Customer.Find(id);
            _context.Customer.Remove(p);
            _context.SaveChanges();
            return true;
           
            
        }

        public List<Customer> getcustomer()
        {
            return _context.Customer.ToList();
        }

        public Customer getcustomerbyid(int id)
        {
            return _context.Customer.Find(id);
        }

        public bool updatecustomer(int id, Customer p)
        {
            _context.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;

            _context.Update(p);
            _context.SaveChanges();
            return true;
        }

        public bool customerexists(int id)
        {
            //private bool CustomerExists(int id)
            {
                return _context.Customer.Any(e => e.CustomerID == id);
            }
        }
    }
}
