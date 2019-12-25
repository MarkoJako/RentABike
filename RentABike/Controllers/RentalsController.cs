using RentABike.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentABike.ViewModels;

namespace RentABike.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Rentals
        [HttpGet]
        public ViewResult Index()
        {
            var rentals = _context.Rentals.Include(m => m.MembershipType).Include(b => b.Bicycle).ToList();
            return View(rentals);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var bicycles = _context.Bicycles.ToList();

            var viewModel = new RentalFormViewModel
            {
                MembershipTypes = membershipTypes,
                Bicycles = bicycles
            };

            return View("RentalForm", viewModel);
        }
        [HttpPost]
         public ViewResult Calculate(Rental rental)
        {
            if(!ModelState.IsValid) 
            {
                var viewModel = new RentalFormViewModel
                {
                    Rental = rental,
                    MembershipTypes = _context.MembershipTypes.ToList(),
                    Bicycles = _context.Bicycles.ToList()
            };

                return View("RentalForm", viewModel);
            }
            var pricePerHour = (from b in _context.Bicycles where (rental.BicycleId == b.Id) select b.PricePerHour).First();
            var membershipDiscountPercent = (from m in _context.MembershipTypes where (rental.MembershipTypeId == m.Id) select m.DiscountRate).First();
            var selectedBike = (from b in _context.Bicycles where (rental.BicycleId == b.Id) select b.Name).SingleOrDefault();
            var selectedMembershipType = (from m in _context.MembershipTypes where (rental.MembershipTypeId == m.Id) select m.Name).SingleOrDefault();
            var bicycleImage = (from b in _context.Bicycles where (rental.BicycleId == b.Id) select b.ImageUrl).SingleOrDefault();
            var bikeQuantity = rental.BikeQuantity;
            var hoursOfRent = rental.HoursOfRent;
            var fullPrice = bikeQuantity * pricePerHour * hoursOfRent;
            decimal fullPriceSlash100 = (decimal)fullPrice / 100;
            decimal membershipDiscountAmount = fullPriceSlash100 * membershipDiscountPercent;
            decimal calculatedPrice = (decimal)fullPrice - membershipDiscountAmount;
            decimal dc = Math.Round(calculatedPrice, 2);
            ViewBag.Price = dc;
            ViewBag.HoursOfRent = hoursOfRent;
            ViewBag.BikeQuantity = bikeQuantity;
            ViewBag.Bike = selectedBike;
            ViewBag.MembershipType = selectedMembershipType;
            ViewBag.Image = bicycleImage;
            _context.Rentals.Add(rental);
            _context.SaveChanges();
            return View("Result");
        }
    }
}