﻿using System.ComponentModel.DataAnnotations;

namespace ProniaPlus.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        [MaxLength(25, ErrorMessage = "It should not exceed 25 characters")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
