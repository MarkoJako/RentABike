    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentABike.Models
{
    public class Bicycle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Price Per Hour (Euro)")]
        public decimal PricePerHour { get; set; }

        [Required]
        [Display(Name = "Wheels Size (Inches)")]
        [StringLength(20)]
        public string WheelsSize { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 50)]
        public int NumberInStock { get; set; }

        [Required]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public BicycleType BicycleType { get; set; }

        [Display(Name = "Bicycle Type")]
        public int BicycleTypeId { get; set; }
    }
}