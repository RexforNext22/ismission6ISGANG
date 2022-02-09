// Author: Ryan Pinkney, Jacob Poor, Tanner Davis, Kevin Gutierrez
// This is the model for the app.

using System;
using System.ComponentModel.DataAnnotations;

namespace ismission6ISGANG.Models
{
    public class Tasks
    {
        // Task id field required and it is the primary key
        [Key]
        [Required]
        public int TaskID { get; set; }

        // The field to input the task text
        [Required]
        public string Task { get; set; }

        // Field to hold the date
        public string Date { get; set; }

        // Field to hold which quadrant it is and also required
        [Required]
        public int Quadrant { get; set; }

        // Set up the primary key foriegn key relationship withe category
        [Required]
        public int CategoryId { get; set; }

        // Link to the category model
        public Category Category { get; set; }

        // Field to hold the completed boolean value
        public bool Completed { get; set; }
    }
}
