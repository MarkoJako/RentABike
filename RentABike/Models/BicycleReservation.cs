using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentABike.Models
{
    public class BicycleReservation
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Customer Email")]
        public string CustomerEmail { get; set; }

        [Required]
        [Display(Name = "Start Ride")]
        public DateTime StartRide { get; set; }

        [Required]
        [Display(Name = "End Ride")]
        public DateTime EndRide { get; set; }

        public Bicycle Bicycle { get; set; }

        [Display(Name = "Bicycle")]
        public int BicycleId { get; set; }
    }
}