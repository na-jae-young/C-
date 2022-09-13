using System;

namespace Interface
{
    public interface ICarStandard   //구현을 강제함 추상클래스랑 같음 ,  차이점-  추상클래스는 자체 함수구현도 가능하다 . 
    {
        void Left();
    }
    abstract class KS
    { 
        public abstract void Back();
    }
    class MyCar : KS, ICarStandard
    {
        public void Left() => Console.WriteLine("좌회전");
        public override void Back() => Console.WriteLine("후진");
    }

    class Interface
{
    static void Main(string[] args)
    {
        
    }
}
}
