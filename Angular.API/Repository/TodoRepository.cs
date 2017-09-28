using Angular.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API.Repository
{
    public class TodoRepository : ITodoRepository
    {
        public static List<Todo> Todos = new List<Todo>();

        public IEnumerable<Todo> GetTodos()
        {
            return Todos;
        }

        public void AddTodo(Todo todo)
        {
            todo.ID = Guid.NewGuid();
            Todos.Add(todo);
        }

        public void DeleteTodo(Todo todo)
        {
            var todoId = todo.ID;
            var todoToRemove = Todos.First(t=>t.ID == todoId);

            Todos.Remove(todoToRemove);
        }
    }
}
