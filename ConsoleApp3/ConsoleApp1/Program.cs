using System;
using System.Collections;

namespace ConsoleApp3
{
    class Car
    {
        //필드
        private string[] names;
        //생성자
        public Car(int length)
        {
            names = new string[length];
        }
        //인덱서
        public string this[int index]      //개체를 개체[index] 식으로 사용가능하게 해줌 
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        //반복기(이터레이터)            //foreach 문 사용 가능하게 해줌 
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i<names.Length; i++)
            {
                yield return names[i];
            } 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car cars = new Car(3);
            cars[0] = "kia";
            cars[1] = "bmw";
            cars[2] = "benz";

            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}
