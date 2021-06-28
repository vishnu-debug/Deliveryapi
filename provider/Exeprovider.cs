using Deliveryapi.Model;
using Deliveryapi.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
    public class Exeprovider:Iexeprovider
    {
        private readonly Iexecutive _repo;
        //  public Productrepo _repo = new Productrepo();
        public Exeprovider()
        {

        }
        public Exeprovider(Iexecutive repo)
        {
            _repo = repo;
        }
        public List<Executive> getexecutive()
        {
            return _repo.getexecutive();
        }
        public Executive addnewexecutive(Executive p)
        {
            _repo.addnewexecutive(p);
            return p;
        }

        public void deleteexecutive(int id)
        {
            _repo.deleteexecutive(id);
        }

        public List<Executive> Getexecutive()
        {
            return _repo.getexecutive();
        }

        public Executive getexecutivebyid(int id)
        {
            return _repo.getexecutivebyid(id);
        }

        public Executive updateexecutive(int id, Executive p)
        {
            _repo.updateexecutive(id, p);
            return p;

        }
        public bool executiveexists(int id)
        {
            return _repo.executiveexists(id);
        }

    }
}
