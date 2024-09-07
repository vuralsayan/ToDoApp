#nullable disable
using TodoApp.Domain.Common;

namespace TodoApp.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
