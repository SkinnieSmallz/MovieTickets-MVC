﻿using System.ComponentModel.DataAnnotations;

namespace ecommerce_mvc.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
