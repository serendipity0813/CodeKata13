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

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < tangerine.Length; i++)
            {
                if (dictionary.ContainsKey(tangerine[i]))
                    dictionary[tangerine[i]]++;
                else
                dictionary.Add((tangerine[i]), 1);
            }

            dictionary = dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);



            foreach (var element in dictionary)
            {
                if (k <= 0) break; 
                if (k >= element.Value)
                {
                    k -= element.Value;
                    answer++;   
                }
                else
                {
                    answer++;
                    break;
                }
            }

            Console.WriteLine(answer);
            return answer;


        }    

        public static int Solution84(string s)  //풀이x - 풀어봐야함 (괄호 회전문제)
        {
            int answer = -1;

            return answer;
        }

        public static int Solution85(int[] elements)
        {
            int answer = 0;
            int sum = 0;
            int numsum;
      
            int[] group = new int[10000000];

            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    numsum = i + j;
                    if (numsum > elements.Length - 1)
                        numsum -= elements.Length;
                    sum += elements[numsum];
                    if (group[sum] == 0)
                    {
                        group[sum]++;
                        answer++;
                    }

                }
                sum = 0;
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static int Solution86(int[] citations)
        {
            int answer = 0;
            int hindex = 0;
            int hcount = 0;


            Array.Sort(citations);


            for (int i = 0; i < citations.Length; i++)
            {
                hindex = citations[i];
                hcount = 0;
                for(int j=i; j< citations.Length; j++)
                {
                    if (citations[j] >= hindex)
                        hcount++;
                }
                if (hcount >= hindex)
                    answer = hindex;
                //else
                //    break;
            }

            Console.Write(answer);
            return answer;

        }

    }
}
