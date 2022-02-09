using System;
using System.ComponentModel.DataAnnotations;

namespace ismission6ISGANG.Models
{
    public class Category
    {
        //new Models Created In order to seperate it from Tasks and create a dropdown menu
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
