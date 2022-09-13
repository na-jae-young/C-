using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car2
    {
        public string Name { get; set; } = "기본차"; // Name 은 private 이고 함수로 출력 입력 가능 , private set; 읽기전용 
        public string name 
        { get { return this.name; } set { this.name = value; } }
    }


    class Program4
    {
        public static void Main(string[] args)
        {
            Car2 car3 = new Car2() { Name = "My Car"};
            Console.WriteLine(car3.Name); //My Car
            car3.name = "my car";
        }
    }
}
