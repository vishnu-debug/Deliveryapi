using Deliveryapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deliveryapi.repo
{
    public interface Iexecutive
    {
        public List<Executive> getexecutive();
        public Executive getexecutivebyid(int id);
        public Executive addnewexecutive(Executive p);
        public void deleteexecutive(int id);
        public Executive updateexecutive(int id, Executive p);
        public bool executiveexists(int id);
    }
}
