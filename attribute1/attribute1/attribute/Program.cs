using System;
using System.Diagnostics;
using System.Reflection;


namespace Attribute  //특성 
{

    public class Car
    {
        [Obsolete("Auto()로 변경하세요.")]  //최신버전으로 사용하도록 유도 
        public void Manual() => Console.WriteLine("수동운전");
        public void Auto() => Console.WriteLine("자동운전");
        [Conditional("DEBUG")] public void Test() => Console.WriteLine("테스트운전");  //디버그 환경에서만 실행 되도록 특성 만듬 
     }


    public class Attribute
    {
            static void Main()
        {
            Car car = new Car();
            car.Manual();
            car.Auto();
            car.Test(); //디버그 모드에서만 실행됨 

        }
    }
}
