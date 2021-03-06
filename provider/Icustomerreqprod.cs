using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
    public interface Icustomerreqprod
    {
        public List<Userreq> getcustomerreq();
        public Userreq getcustomerreqbyid(int id);
        public Userreq addnewcustomerreq(Userreq p);
        public void deletecustomerreq(int id);
        public Userreq updatecustomerreq(int id, Userreq p);
        // ActionResult<List<Customer>> GetCustomer();
        public bool customerreqexists(int id);
    }
}
