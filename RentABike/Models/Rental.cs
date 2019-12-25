using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentABike.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Hours of Rent")]
        public int HoursOfRent { get; set; }

        [Required]
        [Display(Name ="Bicycle Quantity")]
        public int BikeQuantity { get; set; }

        [Required]
        [Display(Name = "Rental Price")]
        public decimal Price { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        public Bicycle Bicycle { get; set; }

        [Display(Name = "Bicycle")]
        public int BicycleId { get; set; }


    }
}