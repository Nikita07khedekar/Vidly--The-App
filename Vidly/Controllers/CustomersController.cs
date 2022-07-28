using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;
using System.Runtime.Caching;

namespace Vidly.Controllers
{
   
    public class CustomersController : Controller
    {
        // GET: Customers

        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
       
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var customer = _context.customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);   
        }
        public ActionResult New()
        {
            var membershipTypes = _context.membershipTypes.ToList();
            var v =new ViewModel.CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm",v);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ViewModel.CustomerFormViewModel
                {
                    Customer= customer,
                    MembershipTypes = _context.membershipTypes.ToList()
                };
                return View("CustomerForm",viewModel);
            }
            if(customer.Id == 0)
            _context.customers.Add(customer);
            else
            {
                var customerInDb = _context.customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.IsSubscribedToNewsLater= customer.IsSubscribedToNewsLater;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }
        public ActionResult Edit(int id)
        {
            var customer=_context.customers.SingleOrDefault(c => c.Id == id);   
            if (customer == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.membershipTypes.ToList()
        };
        return View("CustomerForm",viewModel);
        }
    }
}