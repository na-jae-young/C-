using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory: ITodoRepositoryInMemory // 상속받아서 메서드 구현   ctrl+.  인터페이스 구현 
    {

        private static List<Todo> _todos = new List<Todo>(); //필드생성 

        public TodoRepositoryInMemory() //생성자 
        {
            _todos = new List<Todo>
            {
                new Todo {Id= 1, Title = "ASP.NET Core 학습", IsDone = false},
                new Todo {Id= 2, Title = "Blazor 학슴", IsDone = false},
                new Todo {Id= 3, Title = "C# 학슴", IsDone = true}
            };
        }

        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }
}
