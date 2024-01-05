namespace ContactMeASP.Models
{
    public class ToDo
    {
        public int todoID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool isFinished { get; set; }
    }
}
