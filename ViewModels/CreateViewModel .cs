﻿using System.ComponentModel.DataAnnotations;

namespace atelier2.ViewModels
{
    public class CreateViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Designation { get; set; }
        [Required]
        [Display(Name = "Prix en dinar :")]
        public float Prix { get; set; }
        [Required]
        [Display(Name = "Quantité en unité :")]
        public int Quantite { get; set; }
       
        [Display(Name = "Image :")]
        public IFormFile? ImagePath { get; set; }

    }
}
