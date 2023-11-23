using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    public class Level_30
    {
        public static bool Solution21(int x)
        {
            bool answer = true;
            int num = x;
            int sum = 0;

            while (x > 0)
            {
                sum += x % 10;
                x = x / 10;
            }

            if (num % sum == 0)
                answer = true;
            else
                answer = false;

            Console.WriteLine($"{num%sum}, {answer}");

            return answer;

        }

        public static long Solution22(int a, int b)
        {
            long answer = 0;
            int temp = 0;

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }            


            for( int i = a; i <= b; i++)
            {
                answer += i;
            }

            Console.WriteLine(answer);


            return answer;
        }

        public static int Solution23(int num)
        {
           int answer = 0;
            int count = 0;
            long n = num;

            if(n == 1)
                answer = 0;
            else
            {
                while (answer == 0)
                {
                    if (n == 1)
                    {
                        answer = count;
                        break;
                    }
                    else if(count > 500)
                    {
                        answer = -1;
                        break;
                    }

                    else if (n % 2 == 0)
                    {
                        n = n / 2;
                        count++;
                    }
                    else if(n % 2 == 1)
                    {
                        n = n * 3 + 1;
                        count++;
                    }
 

                }
            }
        
            Console.WriteLine(answer);

            return answer;

        }

        public static string Solution24(string[] seoul)
        {
            string answer = "";
            int num = 0;
            
            for( int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim")
                    num = i;
            }

            answer = $"김서방은 {num} 에 있다";


            Console.WriteLine(answer);

            return answer;
        }

        public static int[] Solution25(int[] arr, int divisor)
        {
            //버그수정 해야함

            int[] answer = new int[10];
            int min = 0;
            int count = 0;
            int check = 0;

            while (count < arr.Length)
            {
                min = arr[count];
                for (int i = count+1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                        min = arr[i];
                }

                if (min % divisor == 0)
                {
                    answer[check] = min;
                    check++;
                }

                count++;
            }

            if (check == 0)
                answer[0] = -1;

            for(int j = 0; j < answer.Length; j++)
            {
                Console.WriteLine(answer[j]);
            }

            return answer;

        }


    }
}
