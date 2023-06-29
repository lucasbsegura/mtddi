using MeuTodoCoreWebApi.Infrastructure.Models;
using System.Collections.Generic;

namespace MeuTodoCoreWebApi.Infrastructure.Repository.Interfaces
{
    public interface ITodoRepository
    {
        List<Todo> GetAll();
        Todo GetById(int id);
        void Create(Todo todo);
        void Update(Todo todo, int id);
        bool Delete(int id);
    }
}
