namespace ToDo_Api.Models
{
	public class ToDo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool isFinished { get; set; } = false;
		public DateTime CreatedDate { get; set; } = DateTime.Now;
	}
}
