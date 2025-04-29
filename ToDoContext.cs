using Microsoft.EntityFrameworkCore;

namespace TaskTrackerCRUDWebApi
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos {  get; set; }
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        // create a SQLite database on first time start
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasData(
                new ToDo { Id = 1, Name = "Hire Aaron Lee", Description = "Hire Aaron Lee for the job.", DueDate = DateTime.Today, Priority = Priority.Medium}
                );
        }

        //public string Name { get; set; }
        //public string Description { get; set; }
        //public DateTime DueDate { get; set; }
        //public Priority Priority { get; set; }
        //public int IsCompleted { get; set; }

        //public DateTime Completion { get; set; }
        //public DateTime Creation { get; set; }



    }
}
