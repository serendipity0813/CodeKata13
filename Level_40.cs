using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    internal class Level_40
    {
        public static string Solution31(int n)
        {
            string answer = "";
            string clap = "수박";
            string halfClap = "수";

            for(int i = 0; i < n/2; i++)
            {
                answer += clap;
            }

            if(n%2 == 1) 
            {
                answer += halfClap;
            }

            Console.WriteLine(answer);

            return answer;
        }



    }
}
