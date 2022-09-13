using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Car
    {
        private readonly string name;

        public Car() //생성자 
        {
            this.name = "기본자동차";
            System.Console.WriteLine("개체생성");
        }

        public Car(string name) //생성자 
        {
            this.name = name;
            System.Console.WriteLine($"{name} 개채생성");
        }

        public void Go() => System.Console.WriteLine($"{name}가 달린다.");

        ~Car()//소멸자 
        {

        }
    }



    //class   - ref, out, params   
    class Bus
    {
        public void Map(ref string m)   // 변수를 받아서 그 변수를 직접 사용 
        {
            m = "참조변경";
        }
        public void Map2(out string m) {   // 비어있는 변수를 받아서 그 변수를 직접 사용 
            m = "참조반환";
        }
        public void Map3(params string[] m) // 매개변수로 받은 모든것을 변수로 만들어서 받음 
        {

        }
    }



    class Program2
    {

        private static string message = "hi";    //필드 


        public static void Main(string[] args)
        {
            int number = 1_234;
            System.Console.WriteLine(number); // 지역변수
            System.Console.WriteLine(message); //필드 , 전역변수(클래스내부)

            Car car1 = new Car();
            car1.Go();
            Car car2 = new Car("좋은자동차");
            car2.Go();

        }
    }
}