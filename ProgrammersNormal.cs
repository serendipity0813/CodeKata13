using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ExceptionServices;
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
            int length = score.GetLength(0);
            int[] answer = new int[length];
            float[,] rank = new float[length, 2];
            float[] value = new float[length];
            
            for(int i=0; i < length; i++)
            {
                value[i] = (score[i,0] + score[i,1]) / 2 + (score[i, 0] + score[i, 1]) % 2;
                rank[i,0] = i;
                rank[i, 1] = value[i];
            }

            Array.Sort(value);
            Array.Reverse(value);

            for (int i = 0; i < length; i++)
            {

                for(int j=0; j < length; j++)
                {
                    if (value[i] == rank[j, 1] && answer[(int)rank[j, 0]] == 0)
                        answer[(int)rank[j,0]] = i+1;
                }

            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(answer[i]);
            }

            return answer;
        }

        public static int Solution86(int n)
        {
            int before = 0;
            int answer = n;
            int count = 0;
            int dif = 100;
            
            while(dif != 0)
            {
                for (int i = before + 1; i <= answer; i++)
                {
                    if (i % 3 == 0)
                        count++;
                    else if (i / 10 == 13)
                        count++;
                    else if (i / 10 == 3)
                        count++;
                    else if (i % 10 == 3)
                        count++;
                }

                before = answer;
                answer += count;
                count = 0;
                dif = answer - before;
            }

            Console.WriteLine(answer);
            return answer;

        }

        public static int Solution87(int a, int b)
        {
            int answer = 0;
            int max = 0;
            int div = 0;

            if (a > b)
                max = a;
            else
                max = b;

            for(int i=1; i<=max; i++)
            {
                if (a % i == 0 && b % i == 0)
                    div = i;
            }

         
            b = b / div;

            while(b > 0)
            {
                if (b == 1)
                {
                    b = 0;
                    answer = 1;
                }
                else if (b % 10 == 0)
                {
                    b = b / 10;
                }
                else if (b % 2 == 0)
                {
                    b = b / 2;
                }
                else if (b % 5 == 0)
                {
                    b = b / 5;
                }
                else
                {
                    b = 0;
                    answer =2;
                }
             
            }
         

            Console.WriteLine(answer);
            return answer;
        }

        public static int Solution88(int chicken)
        {
            int answer = 0;           
            int coupon = 0;
            int bonus = 0;

            bool isChange = true;

            while(isChange)
            {
                coupon += chicken;
                chicken = 0;
                if (coupon >= 10)
                {
                    bonus = coupon / 10;
                    coupon -= bonus * 10;
                    chicken += bonus;
                    answer += bonus;
                }
                else
                    isChange = false;

            }

            Console.WriteLine(answer);
            return answer;
        }



    }



}