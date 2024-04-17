namespace TodoApi.Models
{
    public class TodoItem
    {
        public long id { get; set; }
        public string? name {  get; set; }
        public bool isComplete { get; set; }
        public string? secret { get; set; }
    }
}
