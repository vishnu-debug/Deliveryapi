using Deliveryapi.Model;
using Deliveryapi.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
    public class Customerreqprovider:Icustomerreqprod
    {
        private readonly Icustomerreq _repo;
        //  public Productrepo _repo = new Productrepo();
        public Customerreqprovider()
        {

        }
        public Customerreqprovider(Icustomerreq repo)
        {
            _repo = repo;
        }
        public List<Userreq> getcustomerreq()
        {
            return _repo.getcustomerreq();
        }
        public Userreq addnewcustomerreq(Userreq p)
        {
            _repo.addnewcustomerreq(p);
            return p;
        }

        public void deletecustomerreq(int id)
        {
            _repo.deletecustomerreq(id);
        }

        public List<Userreq> Getcustomerreq()
        {
            return _repo.getcustomerreq();
        }

        public Userreq getcustomerreqbyid(int id)
        {
            return _repo.getcustomerreqbyid(id);
        }

        public Userreq updatecustomerreq(int id, Userreq p)
        {
            _repo.updatecustomerreq(id, p);
            return p;

        }
        public bool customerreqexists(int id)
        {
            return _repo.customerreqexists(id);
        }
    }
}
