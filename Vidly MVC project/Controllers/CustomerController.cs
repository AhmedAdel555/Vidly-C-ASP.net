using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC_project.Models;
using Vidly_MVC_project.ViewModels;
namespace Vidly_MVC_project.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult CustomerForm()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            CustomerMembershipType viewModel = new CustomerMembershipType
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerMembershipType
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges();
            return RedirectToAction("GetAllCustomers", "Customer");
        }

        [Route("customers")]
        public ActionResult GetAllCustomers()
        {
            return View();
        }

        [Route("customers/details/{Id}")]
        public ActionResult GetCustomerDetials(int Id)
        {
            Customer customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);
            
            return View(customer);
        }

        [Route("customers/Edit/{Id}")]
        public ActionResult Edit(int Id)
        {
            CustomerMembershipType viewModel = new CustomerMembershipType
            {
                Customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id),
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }


    }
}