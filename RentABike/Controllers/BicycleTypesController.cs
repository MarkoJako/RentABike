using RentABike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RentABike.Controllers
{
    public class BicycleTypesController : Controller
    {
        private ApplicationDbContext _context;

        public BicycleTypesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: BicycleTypes
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var bicycleTypes = _context.BicyclesTypes.ToList();

            return View("Index", bicycleTypes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult SaveNew(BicycleType bicycleType)
        {
            if (bicycleType.Id == 0)
                _context.BicyclesTypes.Add(bicycleType);
            _context.SaveChanges();
            return RedirectToAction("Index", "BicycleTypes");
        }
        public ActionResult OnGetFind(int id)
        {
            var bicycleTypes = (from t in _context.BicyclesTypes
                                where (t.Id == id)
                                select new
                                {
                                    id = t.Id,
                                    name = t.Name
                                }).ToList();

            return Json(bicycleTypes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int Id, string Name)
        {
            var bicycleTypeInDb = _context.BicyclesTypes.SingleOrDefault(x => x.Id == Id);
            bicycleTypeInDb.Id = Id;
            bicycleTypeInDb.Name = Name;

            _context.SaveChanges();
            return RedirectToAction("Index", "BicycleTypes");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var bicycleType = _context.BicyclesTypes.SingleOrDefault(b => b.Id == id);

            _context.BicyclesTypes.Remove(bicycleType);
            _context.SaveChanges();
            return RedirectToAction("Index", "BicycleTypes");
        }
    }
}