using RentABike.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentABike.ViewModels;
using System.Data.Entity.Validation;


namespace RentABike.Controllers
{
    public class BicyclesController : Controller
    {
        private ApplicationDbContext _context;

        public BicyclesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var bicycles = _context.Bicycles.Include(b => b.BicycleType).ToList();
            if (User.IsInRole("Admin"))
                return View("Index", bicycles);

            return View("IndexForUSers", bicycles);

        }
        [Authorize(Roles = "Admin")]
        public ViewResult New()
        {
            var bicycleTypes = _context.BicyclesTypes.ToList();

            var viewModel = new BicycleFormViewModel
            {
                BicycleTypes = bicycleTypes
            };

            return View("New", viewModel);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var bicycle = _context.Bicycles.SingleOrDefault(b => b.Id == id);
            if (bicycle.Id == 0)
                return HttpNotFound();

            var viewModel = new BicycleFormViewModel()
            {
                Bicycle = bicycle,
                BicycleTypes = _context.BicyclesTypes.ToList()
            };

            if(User.IsInRole("Admin"))
                 return View("BicycleEditForm", viewModel);

            return View("DetailsForUsers", viewModel);
        }

        public ActionResult Details(int id)
        {
            var bicycle = _context.Bicycles.Include(b => b.BicycleType).SingleOrDefault(b => b.Id == id);

            if (bicycle == null)
                return HttpNotFound();

            return View(bicycle);
        }
        public ActionResult DetailsUsersView (int id)
        {
            var bicycle = _context.Bicycles.SingleOrDefault(b => b.Id == id);
            if (bicycle.Id == 0)
                return HttpNotFound();

            var viewModel = new BicycleFormViewModel()
            {
                Bicycle = bicycle,
                BicycleTypes = _context.BicyclesTypes.ToList()
            };

            return View("DetailsForUsers", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult SaveNew(Bicycle bicycle)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new BicycleFormViewModel()
                {
                    Bicycle = bicycle,
                    BicycleTypes = _context.BicyclesTypes.ToList()
                };
                return View("New", viewModel);
            }
            _context.Bicycles.Add(bicycle);
            _context.SaveChanges();
            return RedirectToAction("Index", "Bicycles");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult SaveEdited(Bicycle bicycle)  
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BicycleFormViewModel()
                {
                    Bicycle = bicycle,
                    BicycleTypes = _context.BicyclesTypes.ToList()
                };
                return View("BicycleEditForm", viewModel);
            }
            var bicycleInDb = _context.Bicycles.Single(b => b.Id == bicycle.Id);

            bicycleInDb.Name = bicycle.Name;
            bicycleInDb.WheelsSize = bicycle.WheelsSize;
            bicycleInDb.PricePerHour = bicycle.PricePerHour;
            bicycleInDb.BicycleTypeId = bicycle.BicycleTypeId;
            bicycleInDb.NumberInStock = bicycle.NumberInStock;
            bicycleInDb.ImageUrl = bicycle.ImageUrl;
            bicycleInDb.Description = bicycle.Description;
        
            _context.SaveChanges();
            return RedirectToAction("Index", "Bicycles");
        }
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var bicycle = _context.Bicycles.SingleOrDefault(b => b.Id == id);

            if (bicycle == null)
                return HttpNotFound();

            _context.Bicycles.Remove(bicycle);
            _context.SaveChanges();

            return RedirectToAction("Index", "Bicycles");

        }
    }
}