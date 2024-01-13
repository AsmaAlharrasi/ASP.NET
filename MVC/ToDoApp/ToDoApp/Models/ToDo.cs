namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isFinished { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
