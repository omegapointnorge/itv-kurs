using Microsoft.EntityFrameworkCore;

namespace WebAPI.Database;

public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options)
    {
    }

    public DbSet<Todo.Todo> Todos => Set<Todo.Todo>();
}