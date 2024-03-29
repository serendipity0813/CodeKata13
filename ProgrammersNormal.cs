using System;
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

        public static int[] solution82(string[] keyinput, int[] board)
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

    }



}