using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    public class Level_10
    {

        public static int solution1(int num1, int num2)
        {
            int answer = 0;
            if (num1 < -50000 || num1 > 50000)
            {
                Console.WriteLine("오류 : num1 범위초과 ");
            }
            else if (num2 < -50000 || num2 > 50000)
            {
                Console.WriteLine("오류 : num2 범위초과 ");
            }
            else
            {
                answer = num1 - num2;
                Console.WriteLine(answer);
            }

            return answer;

        }

        public static int solution2(int num1, int num2)
        {
            int answer = 0;
            if (num1 < 0 || num1 > 100)
            {
                Console.WriteLine("오류 : num1 범위초과 ");
            }
            else if (num2 < 0 || num2 > 100)
            {
                Console.WriteLine("오류 : num2 범위초과 ");
            }
            else
            {
                answer = num1 * num2;
                Console.WriteLine(answer);
            }

            return answer;

        }

        public static int solution3(int num1, int num2)
        {
            int answer = 0;
            if (num1 <= 0 || num1 > 100)
            {
                Console.WriteLine("오류 : num1 범위초과 ");
            }
            else if (num2 <= 0 || num2 > 100)
            {
                Console.WriteLine("오류 : num2 범위초과 ");
            }
            else
            {
                answer = num1 / num2;
                Console.WriteLine(answer);
            }

            return answer;

        }

    }
}
