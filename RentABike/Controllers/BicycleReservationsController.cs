using RentABike.Models;
using RentABike.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Data.Entity;

namespace RentABike.Controllers
{
    public class BicycleReservationsController : Controller
    {
        private ApplicationDbContext _context;

        public BicycleReservationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: BicycleReservations for individual user
        [Authorize(Roles = "User")]
        public ActionResult Index()
        {
            var currentUser = (from reserv in _context.BicycleReservations
                               where (User.Identity.Name == reserv.CustomerEmail)
                               select reserv).Include(b => b.Bicycle).ToList();
     
            return View("Index", currentUser);
        }
        [Authorize(Roles = "User")]
        public ActionResult New()
        {
            var bicycles = _context.Bicycles.ToList();

            var viewModel = new BicycleReservationViewModel
            {
                BicycleReservation = new BicycleReservation(),
                Bicycles = bicycles
            };

            return View("NewReservation", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "User")]
        public ActionResult SaveReservation(BicycleReservation bicycleReservation)
        {
            bicycleReservation.CustomerEmail = User.Identity.Name;
          
            _context.BicycleReservations.Add(bicycleReservation);
            _context.SaveChanges();
            return RedirectToAction("Index", "BicycleReservations");
        }
        //GET Reservations for all users (Admin)
        [Authorize(Roles = "Admin")]
        public ActionResult IndexAdmin()
        {
            var reservations = _context.BicycleReservations.Include(b => b.Bicycle).ToList();
            return View("IndexAdmin", reservations);
        }
    }
}