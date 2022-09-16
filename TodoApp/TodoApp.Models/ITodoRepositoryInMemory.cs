using System.Collections.Generic;
namespace TodoApp.Models
{
    public interface ITodoRepositoryInMemory //인터페이스   초기 설계위해  구현 메서드 
    {
        void Add(Todo model); //입력 
        List<Todo> GetAll(); //출력 

    }
}
