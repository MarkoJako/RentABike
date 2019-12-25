using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentABike.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [AtLeast16YearsOld]
        public DateTime Birthdate { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [Phone]
        [MinLength(9, ErrorMessage = "Phone number should be at least 9 number long")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Document Number")]
        public string DocumentNumber { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
    }
}