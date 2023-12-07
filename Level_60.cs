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





            Console.WriteLine(answer);
            return answer;
        }


    }
}
