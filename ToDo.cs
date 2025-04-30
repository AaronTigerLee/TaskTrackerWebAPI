using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskTrackerCRUDWebApi
{
    public enum Priority
    {
        Low, Medium, High
    }

    public class ToDo
    {
        // Generates an ID # sequentially
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public int IsCompleted { get; set; }

        public DateTime? Completion { get; set; }
        public DateTime? Creation { get; set; }
        // add foreign key referencing user IDs once auth is implemented. 

    }
}
