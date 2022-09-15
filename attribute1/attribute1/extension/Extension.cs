using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtension
{
    //STATIC 클래스에 STATIC 메서드로    STRING 클래스를 확장 시킬수있다.   
    static class StringExtension   //확장 클래스  사실상 이름 상관없음    static 으로만 만들면됨 
    {
        public static string Five(this String message) => message.Substring(0, 5);  // 확장 메서드 
    }
    class MyExtension
    {
        static void Main(string[] args)
        {
            string msg = "안녕하세요. 반갑습니다.";
            Console.WriteLine(msg.Five());  //확장함수 사용  
        }
    }
}


//동적 형식   dynamic   자바스크립트의 var 와 같음  타입을 지정해주지않음 

