using System;
 //대리자 - 특전 메서드를 대신 호출해준다.   함수 포인터 
namespace delegater
{
    class DelegateSample
    {
        static void GoForword() => Console.WriteLine("직진");
        static void GoLeft() => Console.WriteLine("좌회전");
        static void GoFast() => Console.WriteLine("과속");
        static void GoBack() => Console.WriteLine("후진");

        delegate void CarDrive();  //  대리자 생성 형식 

        static void Main(string[] args)
        {
            //   CarDrive goHome = new CarDrive(GoForword);  //대리자 생성 
            CarDrive goHome = GoForword;  //대리자 생성
            goHome += GoLeft;  // 대리자에 함수 추가 
            goHome += GoFast;
            goHome -= GoFast;
            goHome += delegate () { Console.WriteLine("정지"); };  // 대리자에 함수 만들어서 추가 ,무명메서드,익명함수
            goHome += () => { Console.WriteLine("우회전"); };  // 람다식 함수 추가 
            goHome(); // 대리자 실행 , goHome.Invoke();



            // 현재는 Action<T>, Func<T>  , Predicate<T>   로도 가능   T 반환값 있을때 반환값 타입 
            Action drive = GoFast;
            drive += GoBack;
            drive += () => { Console.WriteLine("우회전"); };
            drive();

            RunLambda(() => { Console.WriteLine("매개변수로 함수 전달"); });
        }
        static void RunLambda(Action action) => action();// 함수에 함수 전달하여 사용 
    }
}
