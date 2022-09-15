using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//튜블 리터럴  
var r = (1, 2, 3, 4);
int R = r.Item4;   // 4

var fhd = (1920, 1080);

var uhd = (Width: 3840, Height: 2160); // 이름지정
int w = uhd.Width;
int h = uhd.Height;

var boy = (NAME: "JIN", IsStudent: true, age: 13);


(int Width, ushort Height) hd = (1366, 794); // 타입과 이름  지정 
int w1 = hd.Width;
ushort h1 = hd.Height;
Type h1type = hd.Height.GetType();


//함수의 반환값으로 튜플 사용 
static (int,int) Tally1() 
{
    var t = (12, 3);
    return t;
}
int item1 = Tally1().Item1;


static (int Sam, int Count) Tally2()
{
    var t = (12, 3);
    return t;
}
int Sam = Tally2().Sam;



namespace Tuple
{
    class Tuple
    {
        
    }
}
