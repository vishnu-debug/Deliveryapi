using Deliveryapi.Model;
using Deliveryapi.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
    public class Executiveresprod:Iexecutiveresprod
    {
        private readonly Iexecutiveres _repo;
        //  public Productrepo _repo = new Productrepo();
        public Executiveresprod()
        {

        }
        public Executiveresprod(Iexecutiveres repo)
        {
            _repo = repo;
        }
        public List<Executiveres> getexecutivereq()
        {
            return _repo.getexecutivereq();
        }
        public Executiveres addnewexecutivereq(Executiveres p)
        {
            _repo.addnewexecutivereq(p);
            return p;
        }

        public void deleteexecutivereq(int id)
        {
            _repo.deleteexecutivereq(id);
        }

        public List<Executiveres> Getexecutivereq()
        {
            return _repo.getexecutivereq();
        }

        public Executiveres getexecutivereqbyid(int id)
        {
            return _repo.getexecutivereqbyid(id);
        }

        public Executiveres updateexecutivereq(int id, Executiveres p)
        {
            _repo.updateexecutivereq(id, p);
            return p;

        }
        public bool executiveexists(int id)
        {
            return _repo.executiveexists(id);
        }
    }
}
