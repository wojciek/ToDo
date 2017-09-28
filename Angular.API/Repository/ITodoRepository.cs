using Angular.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API.Repository
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetTodos();
        void AddTodo(Todo todo);


        void DeleteTodo(Todo todo);
    }
}
