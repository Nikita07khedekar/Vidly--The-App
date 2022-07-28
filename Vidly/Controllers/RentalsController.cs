using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Rentals
        public ActionResult New()
        {
            return View();
        }

      
    }
}