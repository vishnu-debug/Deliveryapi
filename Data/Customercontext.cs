using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deliveryapi.Model;
using Deliveryapi.repo;

namespace Deliveryapi.Data
{
    public class Customercontext : DbContext
    {
        public Customercontext (DbContextOptions<Customercontext> options)
            : base(options)
        {
        }

        public DbSet<Deliveryapi.Model.Customer> Customer { get; set; }

        public DbSet<Deliveryapi.Model.Executive> Executive { get; set; }

        public DbSet<Deliveryapi.Model.Userreq> Userreq { get; set; }

        public DbSet<Deliveryapi.Model.Executiveres> Executiveres { get; set; }

        

        //public static implicit operator Customercontext(customerrepo v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
