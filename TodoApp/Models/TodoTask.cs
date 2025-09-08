using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class TodoTask
    {
        public Guid Id { get; set; }
        public bool IsCompleted { get; set; }
        [Required] public string TaskName { get; set; }
        public DateTimeOffset? DueDate { get; set; }
    }
}
