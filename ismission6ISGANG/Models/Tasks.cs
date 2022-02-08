using System;
using System.ComponentModel.DataAnnotations;

namespace ismission6ISGANG.Models
{
    public class Tasks
    {
        [Key]
        [Required]
        public int TaskID { get; set; }
        [Required]
        public string Task { get; set; }
        public string Date { get; set; }
        [Required]
        public int Quadrant { get; set; }
        [Required]
        public string Category { get; set; }
        public bool Completed { get; set; }
    }
}
