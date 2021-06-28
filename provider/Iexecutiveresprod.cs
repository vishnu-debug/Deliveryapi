using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.provider
{
  public  interface Iexecutiveresprod
    {
        public List<Executiveres> getexecutivereq();
        public Executiveres getexecutivereqbyid(int id);
        public Executiveres addnewexecutivereq(Executiveres p);
        public void deleteexecutivereq(int id);
        public Executiveres updateexecutivereq(int id, Executiveres p);
      
        public bool executiveexists(int id);
    }
}
