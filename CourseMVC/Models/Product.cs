using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is obrigatory")]
        [MinLength(5, ErrorMessage = "Minimum 5 characters")]
        public string Description { get; set; }

        [Range(1, 100, ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
