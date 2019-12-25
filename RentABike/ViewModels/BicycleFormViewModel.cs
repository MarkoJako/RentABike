using RentABike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentABike.ViewModels
{
    public class BicycleFormViewModel
    {
        public IEnumerable<BicycleType> BicycleTypes { get; set; }
        public Bicycle Bicycle { get; set; }
    }
}