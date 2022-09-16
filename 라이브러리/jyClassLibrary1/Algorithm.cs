using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JyClassLibrary1
{
    public class Algorithm
    {

        public static int[] sort(int[] number)  //오름차순 정렬
        {
            int N = number.Length;
            for(int i = 0; i < N-1; i++)
            {
                for(int j = i+1; j < N; j++)
                {
                    if(number[i] > number[j])
                    {
                        int temp = number[i]; number[i] = number[j]; number[j] = temp;
                    }
                }
            }
        return number;
        }
        
    }
}
// dll 파일 생성됨  빌드시


//업로드 방법 
// 속성  -> nuget 패키지 -> 빌드시 nuget 패키지 생성 클릭 -> 설정  후 빌드  dll파일 생성되는곳에 생성됨 . 

//NUGET에서 갖어와서 사용하는 방법
// 종속성 ->  NUGET 패키지 관리 -> 찾기 검색 설치    

