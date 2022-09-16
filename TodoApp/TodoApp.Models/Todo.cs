using System.Collections.Generic;

namespace TodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
    public class TodoResitoryInMemory : ITodoRepositoryInMemory // 인-메모리 데이터베이스 사용 영역 구현 
    {
        public void Add(Todo model)
        {
            throw new System.NotImplementedException();
        }

        public List<Todo> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
    public class TodoResitorySqlServer : ITodoRepositoryInMemory // SQL 서버 사용시 사용 영역 구현 
    {
        public void Add(Todo model)
        {
            throw new System.NotImplementedException();
        }

        public List<Todo> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
