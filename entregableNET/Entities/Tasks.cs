using entregableNET.DTO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entregableNET.Entities
{
    [Table("Tasks")]
    public class Tasks
    {
        [Key]
        [Column("tasks_id")]
        public int Id { get; set; }

        [Column("title", TypeName = "VARCHAR(50)")]
        public string Title { get; set; }

        [Column("description", TypeName = "VARCHAR(200)")]
        public string Description { get; set; }

        [Column("completed")]
        public bool IsCompleted { get; set; }

        public static implicit operator Tasks(TasksDTO v)
        {
            var task = new Tasks();
            task.Title = v.Title;
            task.Description = v.Description;
            task.IsCompleted = v.IsCompleted;
            return task;
        }
    }
}



