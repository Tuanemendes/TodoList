
using Microsoft.EntityFrameworkCore;
using todo_list_api.api.Domain.Entities;

namespace todo_list_api.api.Infrastruture.Data.Contexts.TodoList
{
    public class TodoListContext :DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options)
        {

        }
        public DbSet<TodoListEntity> TodoList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var todoList = modelBuilder.Entity<TodoListEntity>();
            todoList.ToTable("tb_todolist");
            todoList.HasKey(x => x.Id);
            todoList.Property(x => x.Id).HasColumnName("id_todolist").ValueGeneratedOnAdd();
            todoList.Property(x => x.Description).HasColumnName("description");
            todoList.Property(x => x.TodoStatus).HasColumnName("status");
        }
    }
}