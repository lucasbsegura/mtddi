using MeuTodoCoreWebApi.Infrastructure.Data;
using MeuTodoCoreWebApi.Infrastructure.Models;
using MeuTodoCoreWebApi.Infrastructure.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MeuTodoCoreWebApi.Infrastructure.Repository
{
    public class TodoRepository : ITodoRepository
    {

        private readonly AppDbContext _context;

        public TodoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Todo> GetAll()
        {
            return _context.Todos.ToList();
        }

        public Todo GetById(int id)
        {
            return _context.Todos.FirstOrDefault(x => x.Id == id);
        }

        public void Create(Todo todo)
        {
            _context.Todos.AddAsync(todo);
            _context.SaveChanges();
        }

        public void Update(Todo todo, int id)
        {
            var old = _context.Todos.FirstOrDefault(i => i.Id == id);
            old.Type = todo.Type;
            old.Done = todo.Done;
            _context.Todos.Update(todo);
            _context.SaveChanges();
        }
        public bool Delete(int id)
        {
            var todo = _context.Todos.FirstOrDefault(i => i.Id == id);
            if (todo != null)
            {
                _context.Todos.Remove(todo);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
