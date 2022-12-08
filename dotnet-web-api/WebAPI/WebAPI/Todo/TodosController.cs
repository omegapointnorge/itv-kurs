using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Todo;

[ApiController]
[Route("api/[controller]")]
[Authorize(Policy = "UserLoggedIn")]
public class TodosController : ControllerBase
{
    private readonly ITodoRepository _repository;

    public TodosController(ITodoRepository repository)
    {
        _repository = repository;
    }

    [HttpGet(Name = "GetAll")]
    public async Task<IEnumerable<Todo?>> GetAll()
    {
        return await _repository.GetAsync();
    }

    [HttpGet("{id}", Name = "GetById")]
    public async Task<ActionResult<Todo>> Get(int id)
    {
        var todo = await _repository.GetAsync(id);
        if (todo == null) return NotFound();
        return todo;
    }

    [HttpPost]
    public async Task<ActionResult<Todo>> PostTodoItem(Todo todo)
    {
        var savedTodo = await _repository.CreateAsync(todo);

        return CreatedAtAction(
            nameof(Get),
            new { id = savedTodo.Id },
            savedTodo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTodoItem(long id, Todo todo)
    {
        if (id != todo.Id)
        {
            return BadRequest();
        }

        try
        {
            await _repository.UpdateAsync(todo);
        }
        catch (DbUpdateConcurrencyException)
        {
            return Conflict();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoItem(int id)
    {
        await _repository.DeleteAsync(id);
        return NoContent();
    }
}