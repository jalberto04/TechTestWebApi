using System;
using System.ComponentModel.DataAnnotations;

namespace TechTestWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = null;

        [Range(0.0, Double.MaxValue, ErrorMessage = "{0} must be greater than {1}.")]
        public double Price { get; set; } = 0;
    }
}

