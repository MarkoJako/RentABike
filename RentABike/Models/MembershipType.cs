using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentABike.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int SignUpFee { get; set; }
        [Required]
        public int DurationInMonths { get; set; }
        [Required]
        public int DiscountRate { get; set; }
    }
}