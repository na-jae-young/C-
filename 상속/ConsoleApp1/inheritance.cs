using System;

namespace inheritance
{
    public abstract class CarBase
    {
        public abstract void Left();  //추상 클래스의 추상 메서드    자식클래스들이 Left를 재구현하도록 강제한다 .  override
    }
    public enum CarType { 전기, 내연기관 };
    public class Car:CarBase
    {
        public CarType Style { get; private set; } //부모 필드 
        public Car(CarType cartype) //부모 생성자 
        {
            this.Style = cartype;
        }
        public void Go() 
        {
            Console.WriteLine("달리다"); 
        }
        public override void Left()=>Console.WriteLine("좌회전"); // 추상메서드 구현 재정의  오버라이드
         
    }
    public class Benz : Car  //Car 상속                                      //ctor 탭탭  생성자 양식 생성
    {
        private string Name = "Benz";
        //public CarType Style { get; private set; } = CarType.내연기관;
        public Benz():this(CarType.내연기관){}// 매개변수없는 생성자일때는 내연기관으로 
        public Benz(CarType cartype) : base(cartype) { } //부모클래스의 생성자에 매개변수 전달. 
        public void NameRead() => Console.WriteLine($"{Name}");
    }
    public class Tesla : Car //Car 상속 
    {
        private string Name = "Tesla";
        //public CarType Style { get; private set; } = CarType.전기;
        public Tesla() : this(CarType.전기) { }//본인생성자에 this 값 매개변수로 전달하여 생성
        public Tesla(CarType cartype):base(cartype) { } //부모생성자에 base 값 매개변수로 전달하여 생성

        public void NameRead() => Console.WriteLine($"{Name}");
    }

    public sealed class Future:Car  // 상속 불가능하게 만듬  sealed  
    {
        public Future() : this(CarType.전기) { }//본인생성자에 this 값 매개변수로 전달하여 생성
        public Future(CarType cartype) : base(cartype) { } //부모생성자에 base 값 매개변수로 전달하여 생성

        public new void Go() // 자식클래스에서 메서드 재정의  
        {
            base.Go(); //부모클래스의 Go 메서드 호출 
            Console.WriteLine("날다");
        }
    }


    class InheritanceNote :Object
    {
        static void Main(string[] args)
        {
           
        }
    }
}
