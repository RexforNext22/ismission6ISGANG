using System;
using System.ComponentModel.DataAnnotations;

namespace ismission6ISGANG.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
