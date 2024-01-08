using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    internal class Level_80
    {
        public static int[] Solution71(string today, string[] terms, string[] privacies)
        {
            int[] answer = new int[] { };
            char key = 'A';
            string year;
            string month;
            string day;
            var customers = new Dictionary <string, string>();

            for(int i=0; i<privacies.Length; i++)
            {
                year = privacies[i].Substring(0, 4);
                month = privacies[i].Substring(5, 2);
                day = privacies[i].Substring(8, 2);
                key = privacies[i][11];
                Console.WriteLine(year + " " + month + " " + day +" " + key);
                
            }

            return answer;
        }
    }
}
