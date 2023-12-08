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

            top[0] = score[0];
            answer[0] = top[0];


            for(int i = 1; i < score.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (score[i] >= top[j])
                    {
                        if (j == 0)
                        {
                            top[j + 2] = top[j + 1];
                            top[j + 1] = top[j];
                            top[j] = score[i];
                        }
                        else if (j == 1)
                        {
                            top[j + 1] = top[j];
                            top[j] = score[i];
                        }
                        else if (j == 2)
                        {
                            top[j] = score[i];
                        }

                        break;

                    }

                }
                    answer[i] = top[k-1];

            }


            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }

                return answer;
        }

    }
}
