﻿using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
  public  interface Iexeprovider
    {
        public List<Executive> getexecutive();
        public Executive getexecutivebyid(int id);
        public Executive addnewexecutive(Executive p);
        public void deleteexecutive(int id);
        public Executive updateexecutive(int id, Executive p);
        // ActionResult<List<Customer>> GetCustomer();
        public bool executiveexists(int id);
    }
}
