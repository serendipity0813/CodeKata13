﻿using System;

namespace CodeKata13
{
    internal class Level_70
    {
        public static int[] Solution61(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];
            int winpoint = 0;
            int count = 0;

            for(int i = 0; i < win_nums.Length; i++)
            {
                if (win_nums[i] == 0)
                    count++;
                else
                {
                    for(int j=0; j < lottos.Length; j++)
                    {
                        if (win_nums[i] == lottos[j])
                            winpoint++;
                    }
                }
            }

            answer[0] = 7 - winpoint - count;
            if (answer[0] == 7)
                answer[0] = 6;
            answer[1] = 7 - winpoint;
            if (answer[1] == 7)
                answer[1] = 6;

            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);

            return answer;
        }

        public static int Solution62(string[] babbling)
        {
            int answer = 0;
            int num = 0;
            string[] words = { "aya", "ye", "woo", "ma" };

            for (int i = 0; i < babbling.Length; i++)
            {
                for(int j=0; j < words.Length; j++)
                {
                    babbling[i] = babbling[i].Replace(words[j], $"{j}");
                    babbling[i] = babbling[i].Replace($"{j}{j}", $"{j}" + words[j]);
                }
  

                if(int.TryParse(babbling[i], out num) == true )
                    answer++; 
                Console.WriteLine(babbling[i]);
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static string Solution63(string X, string Y)
        {
            string answer = "";
            int[] xarray = new int[X.Length];
            int[] yarray = new int[Y.Length];
            int[] countarr = new int[10];
            int check1 = 0;
            int check2 = 0;

            for (int i=0; i < X.Length; i++)
            {
                xarray[i] = (int)Char.GetNumericValue(X[i]);
                Console.Write(xarray[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < Y.Length; i++)
            {
                yarray[i] = (int)Char.GetNumericValue(Y[i]);
                Console.Write(yarray[i]);
            }
            Console.WriteLine();

            Array.Sort(xarray);
            Array.Sort(yarray);



            for(int i = 0; i < 10; i++)
            {
                check1 = 0;
                check2 = 0;

                for (int j = 0; j < X.Length; j++)
                {
                    if (xarray[j] == i)
                        check1++;
                }

                for (int j = 0; j < X.Length; j++)
                {
                    if (yarray[j] == i)
                        check2++;
                }

                if (check1 > check2)
                    countarr[i] = check2;
                else if (check2 > check1)
                    countarr[i] = check1;
                else if(check1 == check2)
                    countarr[i] = check1;
                else
                    countarr[i] = -1;

                Console.Write(countarr[i]);
            }

            Console.WriteLine();

            for(int i = countarr.Length -1; i > 0; i--)
            {
                for(int j = 0; j < countarr[i]; j++)
                {
                    answer += i;
                }
            }


            Console.Write(answer);
            return answer;
        }

    }
}
