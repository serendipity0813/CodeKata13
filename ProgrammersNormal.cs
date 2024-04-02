using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CodeKata13
{
    internal class ProgrammersNormal
    {
        public static int Solution78(int balls, int share)
        {
            int answer = 0;
            return answer;
        }

        public static int Solution80(string[] spell, string[] dic)
        {
            int answer = 2;
            string str1 = "";
            string str2 = "";

            for(int i=0; i<dic.Length; i++)
            {
                char[] words = dic[i].ToCharArray();
                Array.Sort(words);
                Array.Sort(spell);

                if (words.Length == spell.Length)
                {
                   for(int j=0; j<words.Length; j++)
                    {
                        str1 += words[j];
                        str2 += spell[j];
                    }

                    if (str1 == str2)
                    {
                        answer = 1;
                        break;
                    }
                    else
                    {
                        str1 = "";
                        str2 = "";
                    }
                }

            }

            Console.WriteLine(answer);

            return answer;

        }

        public static int Solution81(int M, int N)
        {
            int answer = 0;
            int min = 0;
            int dif = 0;

            if (M < N)
            {
                min = M;
                dif = N - M;
            }
              
            else if(N < M)
            {
                min = N;
                dif = M - N;
            }
         
            else
            {
                min = N;
                dif = 0;
            }

            answer = (min * min - 1) + dif * min; 

            
            return answer;
        }

        public static int[] Solution82(string[] keyinput, int[] board)
        {
            int[] answer = new int[] {0, 0};
            int xnum = (board[0] - 1 )/ 2;
            int ynum = (board[1] - 1) / 2;

            for(int i=0; i<keyinput.Length; i++)
            {
                if (keyinput[i] == "up" && answer[1] + 1 <= ynum)
                    answer[1]++;
                else if (keyinput[i] == "down" && answer[1] - 1 >= -ynum)
                    answer[1]--;
                else if (keyinput[i] == "left" && answer[0] - 1 >= -xnum)
                    answer[0]--;
                else if (keyinput[i] == "right" && answer[0] + 1 <= xnum)
                    answer[0]++;
            }
                

            return answer;
        }

        public static int Solution83(int[,] dots)
        {
            int answer = 0;
            int xnum = 0;
            int ynum = 0;

            if (dots[0, 0] != dots[1, 0])
            {
                xnum = dots[1, 0] - dots[0,0];
                if (xnum < 0)
                    xnum = -xnum;
            }
            else
            {
                xnum = dots[2, 0] - dots[0, 0];
                if (xnum < 0)
                    xnum = -xnum;
            }


            if (dots[0, 1] != dots[1, 1])
            {
                ynum = dots[1, 1] - dots[0, 1];
                if (ynum < 0)
                    ynum = -ynum;
            }
            else
            {
                ynum = dots[2, 1] - dots[0, 1];
                if (ynum < 0)
                    ynum = -ynum;
            }

            answer = xnum * ynum;
            Console.WriteLine(answer);
            return answer;
        }

        public static string Solution84(string[] id_pw, string[,] db)
        {
            string answer = "fail";

            for (int i = 0; i < db.GetLength(0); i++)
            {
                if (id_pw[0] == db[i,0])
                {
                    if (id_pw[1] == db[i, 1])
                    {
                        answer = "login";
                        break;
                    }

                    else
                        answer = "wrong pw";
                }
            }

            return answer;
        }

        public static int[] Solution85(int[,] score)
        {
            int[] answer = new int[] { };
            return answer;
        }

    }



}