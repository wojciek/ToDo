using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Angular.API.Models;
using Angular.API.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular.API
{
    [Route("api")]
    public class TodoController : Controller
    {
        private ITodoRepository _repository;

        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("todo/data")]
        public IEnumerable<Todo> Get()
        {
            return _repository.GetTodos();
        }

        [HttpPost]
        [Route("todo/data")]
        public void AddTodo([FromBody]Todo todo)
        {
            if (todo == null)
            {
                BadRequest();
            }

            _repository.AddTodo(todo);
            
        }

        [HttpPost]
        [Route("todo/delete")]
        public void Delete([FromBody]Todo todo)
        {
            _repository.DeleteTodo(todo);
        }

        //[HttpGet]
        //[Route("todo/sample")]
        //public string GetSample()
        //{
        //    return "works";
        //}
    }
}
