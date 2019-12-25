using RentABike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentABike.ViewModels
{
    public class BicycleReservationViewModel
    {
        public BicycleReservation BicycleReservation { get; set; }
        public IEnumerable<Bicycle> Bicycles { get; set; }
    }
}