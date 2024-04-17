using System.Security.Policy;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public long id {  get; set; }
        public string? name { get; set; }
        public bool isComplete { get; set; }
    }
}
