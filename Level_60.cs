using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    internal class Level_60
    {
        public static string Solution51(int[] food)
        {
            string answer = "";
            int[] stage = new int[food.Length];
            int sum = 0;

            for(int i = 0; i < food.Length; i++)
            {
                if(i == 0)
                {
                    stage[i] = 0;
                    sum++;
                }

                else
                {
                    stage[i] = food[i] / 2;
                    sum += stage[i] * 2;
                }

            }

            for (int j = 1; j < food.Length; j++)
            {
                for (int i = 0; i < stage[j]; i++)
                {
                    answer = answer + j;
                }
            }


            answer += stage[0];

            for (int j = food.Length-1; j > 0; j--)
            {
                for (int i = 0; i < stage[j]; i++)
                {
                    answer = answer + j;
                }
            }


            Console.WriteLine(answer);

            return answer;
        }

        public static int Solution52(int a, int b, int n)
        {
            int answer = 0;
            int num = 0;

            while(true)
            {
                num += b * (n / a);
                n = b * (n / a) + n % a;

                if (n < a)
                    break;
            }

            answer = num;


            Console.WriteLine(answer);
            return answer;
        }

        public static int[] Solution53(int k, int[] score)
        {
            int[] answer = new int[score.Length];
            int[] top = new int[k];

            int pivot = k - 1;

            for (int i = 0; i < score.Length; i++)
            {


                if (score[i] > top[0])
                    top[0] = score[i];

                Array.Sort(top);

                answer[i] = top[pivot];

                if (pivot > 0)
                    pivot--;

            }


            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }

                return answer;
        }

        public static string Solution54(int a, int b)
        {
            string answer = "";
            int num = -1;        //1일 부터 시작하므로

            if(a > 1)
            {
                for (int i = 1; i < a; i++)
                {
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                        num += 31;
                    else if (i == 2)
                        num += 29;
                    else
                        num += 30;
                }
            }

            num += b;
            num = num % 7;

            switch (num)
            {
                case 0:
                answer = "FRI";
                    break;
                case 1:
                    answer = "SAT";
                    break;
                case 2:
                    answer = "SUN";
                    break;
                case 3:
                    answer = "MON";
                    break;
                case 4:
                    answer = "TUE";
                    break;
                case 5:
                    answer = "WED";
                    break;
                case 6:
                    answer = "THU";
                    break;

            }


            Console.WriteLine(answer);
            return answer;
        }


        public static string Solution55(string[] cards1, string[] cards2, string[] goal)
        {
            string answer = "";
            int count1 = 0;
            int count2 = 0;

            for(int i = 0; i < goal.Length; i++)
            {
                if (goal[i] == cards1[count1])
                {
                    if(count1 < cards1.Length-1)
                    count1++;
                }

                else if (goal[i] == cards2[count2])
                {

                    if (count2 < cards2.Length - 1)
                        count2++;
                }
                 
                else
                {
                    answer = "NO";
                    break;
                }
                    
                   
            }

            if (answer != "NO")
                answer = "YES";

            Console.WriteLine(answer);
            return answer;
        }

        public static int Solution56(int k, int m, int[] score)
        {
            int answer = 0;
            int price = 0;

            Array.Sort(score);
            Array.Reverse(score);

            for(int j=1; j< score.Length / m + 1; j++)
            {
                price = score[j*m-1] * m;
                answer += price;
            }



            Console.WriteLine(answer);
            return answer;
        }


    }
}
