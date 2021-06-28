using Deliveryapi.Model;
using Deliveryapi.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
    public class Customerprovider : Iprovider 
    {
        private readonly Icustomer _repo;
        //  public Productrepo _repo = new Productrepo();
        public Customerprovider()
        {

        }
        public Customerprovider(Icustomer repo)
        {
            _repo = repo;
        }
        public List<Customer> getcustomer()
        {

            return _repo.getcustomer();
        }
        public bool addnewcustomer(Customer p)
        {
            _repo.addnewcustomer(p);
            return true;
        }

        public bool deletecustomer(int id)
        {
            _repo.deletecustomer(id);
            return true;
        }

        public List<Customer> Getcustomer()
        {
            return _repo.getcustomer();
        }

        public Customer getcustomerbyid(int id)
        {
            return _repo.getcustomerbyid(id);
        }

        public bool updatecustomer(int id, Customer p)
        {
            _repo.updatecustomer(id, p);
            return true;

        }
        public bool customerexists(int id)
        {
            return _repo.customerexists(id);
        }
    }
}
