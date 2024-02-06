using todo_list_api.api.Domain.Enums;

namespace todo_list_api.api.Domain.Entities
{
    public class TodoListEntity
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Status TodoStatus { get; set; }
    }
}