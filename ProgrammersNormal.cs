using System;

namespace CodeKata13
{
    internal class ProgrammersNormal
    {
        public static int Solution78(int balls, int share)
        {
            int answer = 0;
            return answer;
        }

        public static int Solution81(string[] spell, string[] dic)
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


    }



}