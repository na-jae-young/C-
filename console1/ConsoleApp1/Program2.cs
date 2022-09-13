using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1      //namespace 
{
    public class ClassCode    //class
    {
        public static void ab() { }
        public void abc() { }
    }


    class Program1           //class 
    {
        struct Point { public int x; public int y; }
        enum Animal { mouse, cow, tiger };

        class Square
        {
            public int x;
            public int y;
            public static string Word;
        }

        static void Main(string[] args) // 진입지점
        {

            int number = 1_234;
            //구조체
            Point point;
            point.x = 100;
            point.y = 100;
            Console.WriteLine($"{point.x} {point.y}");

            //열거형 만들기 
            Animal animal = Animal.tiger;
            Console.WriteLine($"{nameof(Animal.cow)},{(int)Animal.tiger}");   // tiger 2


            //CLASS 
            Square square = new Square();
            square.x = 100;
            square.y = 10;
            //class static 활용 
            Square.Word = "word"; //static 지정한건 바로 사용 가능 
            //Square.x ,y 는 사용할려면  객체를 만들어야함 

            Random random = new Random();
            random.Next();


            string s = "hello";
            Console.WriteLine(s is string);  //true, string 으로 변형 가능한가????

            object x = 1234;
            string st = x as string;   //null , 변환이 가능하다면 string 으로 변환주고  불가능하면 null 값을 반환해준다. 
            object x2 = "1234";
            string st1 = x2 as string;  // "1234"

            //문자열 다루기 
            string str3 = "hello world";
            str3.Replace("hello", "안녕");
            string str4 = String.Concat("안녕", "하세요");   // +   , $"{}{}"  , string.Format("{0}{1}",str1,str2)
            Console.WriteLine(str4.Length); // 5

            str4.ToCharArray(); // 문자열 배열로 변경 

            //문자열 비교 

            string.Equals(str3, str4,   StringComparison.InvariantCultureIgnoreCase ); // 대소문자 구분함 , 3번째 잇으면 구분안함
            //true ,false  

            str3.Equals(str4, StringComparison.InvariantCultureIgnoreCase);



            //예외처리 
            try
            {

                throw new Exception("내가만든 에러");  //에러발생시킬수있음 
            }
            catch(Exception ex)
            {
                //if(typeof ex == FormatException) { }     에러 종류별로 구분되어 있어 활용가능 
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("end");
            }


            // 컬렉션   (배열 리스트 사전 )

            string[] strarr = { "red", "blue", "green" };
            Array.Sort(strarr);  // 정렬 
            Array.Reverse(strarr); // 역순 

            // 배열은 크키를 변경할수 없음   단점 임     
            //컬렉션을 사용하면 크키 변경 가능 

            // using System.Collections.Generic;


            Stack stack = new Stack(); //스택  POP  PUSH     마지막에 들어온거 먼저 나옴 
            Queue queue = new Queue();  //큐 Enqueue  Dequeue  먼저들어온거 먼저나옴 

            ArrayList list = new ArrayList(); // 리스트 Add RemoveAt Insert     

            Hashtable hashtable = new Hashtable(); //문자열 인덱스를 사용가능 하다 .
            hashtable[0] = "sdfsdf";
            hashtable["sfsdfsf"] = "sdfsdfsdf";


            // 제네릭 

            List<int> numb = new List<int>();

            //사전 
            Dictionary<int, string> todos = new Dictionary<int, string>();
            todos.Add(1, "C#");


            Nullable<bool> tt = null;   // null 값 가능  

            bool? ttt = null;   // null 가능 


            //  ?? 연산자    null 이면 뒤에값으로 치환하라 .
            string nullvalue = null;
            string message = nullvalue ?? "null이면 새로운 값으로 초기화해라 ";
            // null 이면 뒤에 값 대입 해라 


            // null 조건문   연산자   ?. 
            //null 값이 아니면  뒤에것을 실행하라   ,  null값이면 그냥 null을 반환해라 

            double? dd = null; // null 허용 

            dd?.ToString();  // null      null 값이니까 그냥 null 허용 

            double? ddd = 1.0;
            ddd?.ToString(); // "1"    null 값이 아니라서 뒤에 함수 실행 
            ddd?.ToString("#.00"); // 소수점 둘째자리 까지 

            List<string> list1;
            list1 = null;
            
            var num = list1?.Count ?? 0; 
            // list1 이 null 이라서 null을 반환하고 null값이 유지되었기때문에 ?? 에 의해 null값이면 뒤에 값으로 취한되므로 0 이된다.

            // class
            ClassCode classcode1 = new ClassCode();  //개체
            ClassCode classcode2 = new ClassCode();
            classcode1.abc();  //public 
            ClassCode.ab();   //public static

            //컨트롤 +시프트 +위아래   같은것으로 이동 





        }
    }
}