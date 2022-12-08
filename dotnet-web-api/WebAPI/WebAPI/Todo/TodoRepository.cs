using Microsoft.EntityFrameworkCore;
using WebAPI.Database;

namespace WebAPI.Todo;

public class TodoRepository : ITodoRepository
{
    private readonly TodoDb _db;

    public TodoRepository(TodoDb db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Todo>> GetAsync()
    {
        return (await _db.Todos.ToListAsync())!;
    }

    public async Task<Todo?> GetAsync(int id)
    {
        return await _db.Todos.FindAsync(id);
    }

    public async Task<Todo> CreateAsync(Todo todo)
    {
        _db.Todos.Add(todo);
        await _db.SaveChangesAsync();
        return todo;
    }

    public async Task UpdateAsync(Todo todo)
    {
        var todoToUpdate = await GetAsync(todo.Id);

        if (todoToUpdate == null) return;

        todoToUpdate.IsComplete = todo.IsComplete;
        todoToUpdate.Name = todo.Name;

        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var todoItem = await _db.Todos.FindAsync(id);
        if (todoItem != null)
        {
            await _db.SaveChangesAsync();
            _db.Todos.Remove(todoItem);
        }
    }
}