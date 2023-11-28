using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    internal class Level_40
    {
        public static string Solution31(int n)
        {
            string answer = "";
            string clap = "수박";
            string halfClap = "수";

            for(int i = 0; i < n/2; i++)
            {
                answer += clap;
            }

            if(n%2 == 1) 
            {
                answer += halfClap;
            }

            Console.WriteLine(answer);

            return answer;
        }

        public static int Solution32(int[] a, int[] b)
        {
            int answer = 0;

            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }


            Console.WriteLine(answer);
            return answer;

        }

        public static int Solution33(int left, int right)
        {
            int answer = 0;
            int count = 0;


            for (int i = left; i<= right; i++)
            {
                count = 0;
                for(int j=1; j<=i; j++)
                {
                    if (i % j == 0)
                        count++;

                }
                if (count % 2 == 0)
                    answer += i;
                else if (count % 2 == 1)
                    answer -= i;

      
            }
            

            Console.WriteLine(answer);
            return answer;

        }

        public static string Solution34(string s)
        {
            string answer = "";
            string[] word = new string[s.Length];
            
            for(int i=0; i<s.Length; i++)
            {
                word[i] = s.Substring(i, 1);
            }

            Array.Reverse(word);

            for (int i = 0; i < s.Length; i++)
            {
                answer += word[i];
            }


            Console.WriteLine(answer);
            return answer;

        }


        public static long Solution35(int price, int money, int count)
        {
            int answer = 0;
            int sum = 0;

            for(int i =1; i<=count; i++)
            {
                sum += price * i;
            }

            if (sum > money)
                answer = -(money - sum);
            else
                answer = 0;

            Console.WriteLine(answer);  
            return answer;
        }


        public static bool Solution36(string s)
        {
            bool answer = true;

            return answer;
        }


    }
}
