using System.ComponentModel.DataAnnotations;
using Assignment_12._3.Models;
namespace Assignment_12._3.Models
{
    public class Product
    {
        [Display(Name ="Item ID")]
        [Required]
        public int Id { get; set; }

        [Display(Name ="Shoe Name")]
        [Required]
        [MaxLength(50, ErrorMessage ="Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Display(Name="Brief Description")]
        [Required]
        [MaxLength(500, ErrorMessage ="Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string ImageName { get; set; }
    }
}
