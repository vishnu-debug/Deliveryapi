using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Deliveryapi.Data;
using Deliveryapi.Model;
using Deliveryapi.provider;

namespace Deliveryapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly Iprovider _prod;

        public CustomersController(Iprovider prod)
        {
            _prod = prod;
        }

        // GET: api/Customers
        [HttpGet]
        public ActionResult<List<Customer>> GetCustomer()
        {
            return  _prod.getcustomer();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public  ActionResult<Customer> GetCustomer(int id)
        {
            
            return _prod.getcustomerbyid(id);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutCustomer(int id, Customer customer)
        {
       

            try
            {
                _prod.updatecustomer(id, customer);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_prod.customerexists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Customer> PostCustomer(Customer customer)
        {
            _prod.addnewcustomer(customer);
            return CreatedAtAction("getcustomer", new { id = customer.CustomerID }, customer);

        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public  IActionResult DeleteCustomer(int id)
        {
            _prod.deletecustomer(id);

           return NoContent();
        }

        //private bool CustomerExists(int id)
        //{
        //    return _prod.Customer.Any(e => e.CustomerID == id);
        //}
    }
}
