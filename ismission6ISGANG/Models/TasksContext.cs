using System;
using Microsoft.EntityFrameworkCore;

namespace ismission6ISGANG.Models
{
    public class TasksContext: DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options) : base(options)
        {
        }
    }
}
