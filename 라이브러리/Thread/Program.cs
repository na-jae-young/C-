using System;
using System.Threading;
//Thread 는 작업자 한 명을 뜻함,   멀티 thread  ,  작업자 몇명이 작업하게 할거냐 를 정하는것  async await 

namespace Thread_ex
{
    class Restaurant
    {
        public static void MakeFood()
        {
            Console.WriteLine($"요리 시작");
            DateTime start = DateTime.Now;

            void Egg()
            {
                Thread.Sleep(3000);
                Console.WriteLine("달걀3초");
            }
            void Soup()
            {
                Thread.Sleep(5000);
                Console.WriteLine("스프5초");
            }
            Thread t1 = new Thread(Egg);  // Egg 를 작업하는 작업자 생성
            Thread t2 = new Thread(Soup); // Soup 를 작업하는 작업자 생성 

            t1.Start();  t2.Start();  // async   비동기화로 실행 
            t1.Join();   t2.Join(); // await     비동기로 시작된 작업자들이 끝날때까지 여기서 기다린다.


            Console.WriteLine($"요리종료 :{(DateTime.Now - start).TotalSeconds}");
        }
    }
    public class MainClass
    {
        static void Main(string[] args)
        {
            Thread_ex.Restaurant.MakeFood();
        }
    }
}
