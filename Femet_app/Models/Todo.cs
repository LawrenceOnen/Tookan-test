using Microsoft.EntityFrameworkCore;

namespace Femet_app
{
    public class TodoItemDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set;}
    }
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}