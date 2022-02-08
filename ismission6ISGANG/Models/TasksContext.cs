using System;
using Microsoft.EntityFrameworkCore;

namespace ismission6ISGANG.Models
{
    public class TasksContext: DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options) : base(options)
        {
        }

        public DbSet<Tasks> responses { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School"},
                new Category { CategoryId = 3, CategoryName = "Work"},
                new Category { CategoryId = 4, CategoryName = "Church"}
            );

            mb.Entity<Tasks>().HasData(
                new Tasks
                {
                    TaskID = 1,
                    Task = "Crises",
                    Date = "03/12/22",
                    Quadrant = 1,
                    CategoryId = 1,
                    Completed = false
                },
                new Tasks
                {
                    TaskID = 2,
                    Task = "Relationship Building",
                    Date = "04/15/22",
                    Quadrant = 2,
                    CategoryId = 2,
                    Completed = false
                },
                new Tasks
                {
                    TaskID = 3,
                    Task = "Interruptions",
                    Date = "2/28/22",
                    Quadrant = 3,
                    CategoryId = 3,
                    Completed = false
                },
                new Tasks
                {
                    TaskID = 4,
                    Task = "Some Phone Work",
                    Date = "04/01/22",
                    Quadrant = 4,
                    CategoryId = 3,
                    Completed = true
                }
            );
        }
    }
}
