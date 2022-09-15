using System;


namespace
{

    public class Car
    {
        [Obsolete]
        public void Manual() => Console.WriteLine("수동운전");
        public void Auto() => Console.WriteLine("자동운전");
    }


    public class Attribute
    {
	
	    {
            static void Main()
        {
            Car car = new Car();
            car.Manual();
            car.Auto();
        }
    }
}
}