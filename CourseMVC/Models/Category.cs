
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseMVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is obrigatory")]
        [MinLength(5, ErrorMessage = "Minimum 5 characters")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
