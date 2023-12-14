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
            string[] words = { "aya", "ye", "woo", "ma" };

            for (int i = 0; i < babbling.Length; i++)
            {
                babbling[i] = babbling[i].Replace(words[i], " ");
                Console.WriteLine(babbling[i]);
            }


            return answer;
        }

    }
}
