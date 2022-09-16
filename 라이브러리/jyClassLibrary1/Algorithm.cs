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
// dll 파일 생성됨 