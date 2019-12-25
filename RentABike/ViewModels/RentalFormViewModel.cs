using RentABike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentABike.ViewModels
{
    public class RentalFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public IEnumerable<Bicycle> Bicycles { get; set; }
        public Rental Rental { get; set; }
    }
}