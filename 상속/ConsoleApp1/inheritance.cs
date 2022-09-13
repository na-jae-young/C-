using System;

namespace inheritance
{
    public abstract class CarBase
    {
        public abstract void Left();  //추상 클래스의 추상 메서드    자식클래스들이 Left를 재구현하도록 강제한다 .  
    }
    public enum CarType { 전기, 내연기관 };
    class Car
    {
        public void Go() 
        {
            Console.WriteLine("달리다"); 
        }
    }
    class Benz : Car  //Car 상속 
    {
        private string Name = "Benz";
        public CarType Style { get; set; } = CarType.내연기관;
        public void NameRead() => Console.WriteLine($"{Name}");
    }
    class Tesla : Car //Car 상속 
    {
        private string Name = "Tesla";
        public CarType Style { get; set; } = CarType.전기;
        public void NameRead() => Console.WriteLine($"{Name}");
    }
    class InheritanceNote :Object
    {
        static void Main(string[] args)
        {
           
        }
    }
}
