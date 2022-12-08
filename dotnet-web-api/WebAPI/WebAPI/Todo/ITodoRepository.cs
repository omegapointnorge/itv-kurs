namespace WebAPI.Todo;

public interface ITodoRepository
{
    Task<IEnumerable<Todo>> GetAsync();
    Task<Todo?> GetAsync(int id);
    Task<Todo> CreateAsync(Todo todo);
    Task UpdateAsync(Todo todo);
    Task DeleteAsync(int id);


}