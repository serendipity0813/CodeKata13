using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    internal class Level_90
    {
        public static int Solution81(int[] arr)
        {
            int answer = 1;
            int n = 0;
            int m = 0;
            int temp = 0;

            answer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                n = answer;
                m = arr[i];
                while (m > 0)
                {
                    temp = n % m;
                    n = m;
                    m = temp;
                }

                answer = (answer * arr[i] / n);

            }



            Console.WriteLine(answer);

            return answer;
        }   //유클리드 호제법 (n개 수의 최소공배수)

        public static long Solution82(int n)        //피보나치, 점화식
        {
            long answer = 1;
            long before = 1;
            long temp = 0;

            for(int i=2; i<=n; i++)
            {
                temp = answer;
                answer = answer + before;
                before = temp;
                answer = answer % 1234567;
            }

            Console.Write(answer);
            return answer;

        }

        public static int Solution83(int k, int[] tangerine)
        {
            int answer = 0;
            return answer;
        }


    }
}
