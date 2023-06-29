using MeuTodoCoreWebApi.Infrastructure.Models;
using MeuTodoCoreWebApi.Infrastructure.Repository.Interfaces;
using MeuTodoCoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MeuTodoCoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        public readonly ITodoRepository _repository;

        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("todos")]
        public IActionResult GetAsync()
        {
            var todos = _repository.GetAll();

            return Ok(todos);
        }

        [HttpPost]
        [Route("todos")]
        public async Task<IActionResult> PostAsync([FromBody] TodoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var todo = new Todo
            {
                Date = System.DateTime.Now,
                Done = false,
                Type = model.Type
            };

            try
            {
                _repository.Create(todo);
                return Created($"v1/todos/{todo.Id}", todo);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
