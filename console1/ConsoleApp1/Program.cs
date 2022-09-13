using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args) // 진입지점
        {
            // 네임스페이스.클래스.메서드()   system.console.writeline();
            Console.WriteLine("Hello World!");
            Console.Write("줄바꿈없음");
            Console.WriteLine("Hello World!\"\'");
            Console.WriteLine("{0}", "hello , c#");  // {0} 자리표시자 , 개체가 표시될 틀 
            //주석 ;  /* */
            Console.WriteLine("{0},{1}", "HELLO", "C#");

            Console.WriteLine('A'); // 문자 하나는 작은 따움표로  문자열은 큰 따움표


            int number;
            number = 1234;
            number = 1_234;  // 구분자 1,234
            int num1, num2, num3;

            const int max = 100; //상수


            //실수 
            double PI = 3.14;
            double pi = 3.14d;
            float f = 3.14f;// 접미사 f를 붙여야만 한다 . 안붙이면 더블형이다. 
            decimal money = 123.23m; //정밀한 계산할때 사용 



            //정수
            sbyte sb = 127;
            short st = 32767;
            int i = Int32.MaxValue;
            long l = Int64.MaxValue;
            Console.WriteLine("{0} {1} {2} {3}", sb, st, i, l);

            //nullalble
            int? inull = null;  // null 가능 타입 으로 바꿈 null 허용

            //문자
            char g = 'a';    // 문자 , 숫자 큰따움표 안됨 
            char t = '\n';


            //문자열
            string str = "sdfsdfs";
            string multiLines = @"
                안녕하세요.
                반갑습니다.
            
            ";
            Console.WriteLine(multiLines);

            //문자열 연결 

            string msg = string.Format("{0}남 {1}", "홍길동", "안녕하세요");

            string name = "홍길동";
            string hello = "안녕하세요";
            string msg1 = ($"{name}님 {hello}");
            string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}";

            string msg2 = name + '님' + hello;

            //boolean

            bool bo = true; //true false


            System.Console.WriteLine("name:");
            string name2 = Console.ReadLine();
            System.Console.WriteLine($"{name2}");

            int x = Console.Read();  // 문자를 받아 아스키코드로 반환 한다 . INT 형 반환 
            Console.WriteLine(x);
            Console.WriteLine(Convert.ToChar(x));  //Convert.ToInt32(x);

            //타입 반환 
            Console.WriteLine(x.GetType());


            //2진수로 변경 

            Convert.ToString(x, 2); //"1010"
            Convert.ToString(x, 2).PadLeft(8, '0'); //"00001010"

            //10진수로 변경 
            Convert.ToInt32("00001010", 2); //10

            //var  처음에 오는 타입을 타입으로 잡아준다. 
            //dynamic 모든것을 다 담을수 잇다.

            // num = num -1
            // num -= 1
            //--num;
            // ins y = ++x  , int y = x++    


            if (true)
            {
                int sd = 12;
            }
            else if (false)
            {
                int sd = 123;
            }
            else
            {
                int sd = 1234;
            }


            for (int y = 0; y < 10; y++)
            {

            }

            while (true)
            {

            }

            do
            {

            } while (true);

            // continue   break
            int[] numarr = { 1, 2, 3, 4, 5, };
            foreach (int n in numarr)
            {

            }

            //switch
            int nu = 1;
            switch (nu) {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }


            //배열 

            string arrstring = "1234";
            // arrstring[0]; // '1'
            // arrstring[1]; //'2'
            // arrstring[-1]  // -1 index 없음 
            // "abc"[0] ; // 'a'
            // "abc"[1]; // 'b'

            int[] numbers = { 0, 1, 2, 3, 4, 5 };

            int[] numbers2 = new int[3];  //3칸 배열 

            int[,] number3 = new int[2, 3];


            //함수
            static char func(char a = 'd')
            {
                return 'a';
            }

            static void func2()
            {
                Console.WriteLine("sdfsdf");
            }

            static void func3() => Console.WriteLine(func('c'));


            //구조체들 사용 예시 
            //날짜
            Console.WriteLine(DateTime.Now - (new DateTime(2020, 1, 1)));  //지난시간 
            Console.WriteLine((DateTime.Now - (new DateTime(2020, 1, 1))).TotalDays); //지난 일수 
            //문자메서드 
            Console.WriteLine(Char.ToUpper('a'));
            Console.WriteLine(Char.IsWhiteSpace(' '));
            Console.WriteLine(Char.IsWhiteSpace('a'));
            Console.WriteLine(Char.IsDigit('1'));
            Console.WriteLine(Char.IsLetterOrDigit(' '));
            //Guid
            Guid.NewGuid().ToString(); // 전세계적으로 글로벌로 유니크한 아이디 값을 문자열 형식으로 반환하라 


            //열거형 형식 사용
            Console.ForegroundColor = ConsoleColor.Red; //열거형 
            Console.WriteLine("red");  //메서드
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow; //열거형
            Console.ResetColor();
            

            
            //열거형 만들기 
            //enum Animal { mouse, cow, tiger };
            //Animal animal = Animal.tiger;




        }
    }
}
