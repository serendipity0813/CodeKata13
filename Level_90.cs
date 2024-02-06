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

            for (int i = 2; i <= n; i++)
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
                for (int j = i; j < citations.Length; j++)
                {
                    if (citations[j] >= hindex)
                        hcount++;
                }

                if (hcount >= hindex && answer < hindex)
                    answer = hindex;
                else if (hcount < hindex && answer < hcount)
                    answer = hcount;


            }

            if (answer == 0)
                answer = citations.Length;

            Console.Write(answer);
            return answer;

        }

        public static long[] Solution87(int n, long left, long right)
        {
            long[] answer = new long[right - left + 1];
            int[,] arr = new int[n,n];
            long line;
            long col;

            line = left / n;
            col = left % n;

            for(long i=0; i<right - left + 1; i++)
            {
                if(col + i == n)
                {
                    col -= n;
                    line++;
                }

                if (line > col + i)
                    answer[i] = line + 1;
                else
                    answer[i] = col + i + 1;
            }

            for(int j=0; j<answer.Length; j++)
            {
                Console.Write(answer[j]);
            }
            return answer;

        }

        public static int[,] Solution88(int[,] arr1, int[,] arr2)
        {
            int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];

            for(int i=0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        answer[i, j] += arr1[i, k] * arr2[k, j];
                    }
                    Console.Write(answer[i, j] + " ");
                }
                Console.WriteLine(); 
            }


            return answer;
        }

        public static int Solution89(string[] want, int[] number, string[] discount)
        {
            int answer = 0;
            int numberSum = 0;
            bool check = true;
            Dictionary<string, int> items = new Dictionary<string, int>();

            for(int i=0; i<number.Length; i++)
            {
                //넘버합 구하고 딕셔너리 기본값 추가
                numberSum += number[i];
                items.Add(want[i], number[i]);
            }

            for (int i = 0; i < discount.Length - numberSum + 1; i++)
            {
                check = true;
                //딕셔너리 벨류 초기화
                for (int j = 0; j < want.Length; j++)
                {
                    items[want[j]] = number[j];
                }


                for (int j = i; j < numberSum + i; j++)
                {
                    if (want.Contains(discount[j]))
                    {
                        items[discount[j]]--;
                    }
       
                }

                for (int j = 0; j < want.Length; j++)
                {
                    if (items[want[j]] > 0)
                        check = false;
                }

                if (check)
                    answer++;
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static int Solution90(string[,] clothes)
        { 
            int answer = 0;

            return answer;
        }

    }

}
