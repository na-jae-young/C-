using System;

namespace Event
{
    public partial class Car //부분클래스    필드,메서드 , 이벤트 생성자 ,대리자 등을 따로 관리할때 사용 
    {
        public string NAME { get; set; }
    }
    public partial class Car
    {
        private int _fuelGauge; //필드
        public int FuelGauge //필드 표현
        {
            get { return _fuelGauge;  }
            set 
            { 
                _fuelGauge = value;
                OnFuelEvent();
            }
        }
        public Car() //생성자 
        {
            _fuelGauge = 25;
        }
        public void Go() //메서드 
        {
            Console.WriteLine("운전");
            FuelGauge -= 5;  //필드의 SET 실행 
        }
        public delegate void FuelEmptyNotification();  // 대리자 , 함수포인터 , 콜백함수 
        public event FuelEmptyNotification FuelEmptyReached; //이벤트 생성 
        //public event Action FuelEmptyReached;  //위에 두줄 (매개변수 없고 반환값없는 대리자) 은 아래 한줄로 표현 가능 
        public void OnFuelEvent() // 이벤트 대리자에 함수가 추가되어 있다면 추가된 함수들을 실행시키는 메서드 
        {
            Console.WriteLine($"연료상태: {_fuelGauge}%");
            if (_fuelGauge < 20)
            {
                if (FuelEmptyReached != null)
                {
                    FuelEmptyReached();
                }
            }
        }
    }

    class EventAndDelegate
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached;  // 이벤트 방생시 실행할 함수 추가 
            car.FuelEmptyReached += () => 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("비상");
                Console.ResetColor();
            };
            car.Go();
            car.Go();
           // car.OnFuelEvent(); //이벤트 실행 
        }

        //이벤트 핸들러 
        private static void Car_FuelEmptyReached() //이벤트 방생시 실행할 함수
        {
            Console.WriteLine("연료부족");
        }
    }
}
