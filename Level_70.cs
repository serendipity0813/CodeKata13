using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int[] countArr = new int[10];
            int check1 = 0;
            int check2 = 0;
            

            for(int i = 0; i<10; i++)
            {
                //이부분 고쳐야함 (특정숫자 갯수 체크하도록)
                char flag = (char)i;             
                check1 = X.Count( f=> ( f == flag));
                check2 = Y.Count( f => (f == flag));
                if(check1 > check2)
                    countArr[i] = check1;
                else if(check1 < check2)
                    countArr[i] = check2;
                Console.Write(countArr[i]);
            }

            for(int i = 9; i >= 0 ; i--)
            {
                if (countArr[i] > 0)
                {
                    for (int j = 0; j < countArr[i]; j++)
                    {
                        answer += $"{i}";
                    }
                }
            }

            Console.Write(answer);
            return answer;
        }

    }
}
