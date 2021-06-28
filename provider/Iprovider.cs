using Deliveryapi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
  public  interface Iprovider
    {
        //object Customer { get; }

        public List<Customer> getcustomer();
        public Customer getcustomerbyid(int id);
        public bool addnewcustomer(Customer p);
        public bool deletecustomer(int id);
        public bool updatecustomer(int id, Customer p);
       // ActionResult<List<Customer>> GetCustomer();
        public bool customerexists(int id);
    }
}
