using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.repo
{
    public interface Icustomer
    {
      
        public List<Customer> getcustomer();
        public Customer getcustomerbyid(int id);
        public bool addnewcustomer(Customer p);
        public bool deletecustomer(int id);
        public bool updatecustomer(int id, Customer p);
        public bool customerexists(int id);



    }
}
