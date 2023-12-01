using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    internal class Level_50
    {
        public static string Solution41(string s)
        {
            string answer = "";
            int length = 0;


            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] == ' ')
                {
                    answer += s[j];
                    length = 0;
                }
                else if(length % 2 == 0)
                {
                    answer += s[j].ToString().ToUpper();
                    length++;
                }
                else
                {
                    answer += s[j].ToString();
                    length++;
                }

            }


            Console.WriteLine(answer);  
            return answer;
        }

        public static int Solution42(int[] number)
        {
            int answer = 0;

            for(int i = 0; i < number.Length; i++)
            {
                for (int j = i+1; j < number.Length; j++)
                {
                    for (int k = j+1; k < number.Length; k++)
                    {
                        if (number[i] + number[j] + number[k] == 0)
                            answer++;
                    }
                }
            }


            Console.WriteLine(answer);
            return answer;
        }

    }
}
