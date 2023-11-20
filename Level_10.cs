using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    public class Level_10
    {

        public static int Solution1(int num1, int num2)
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

        public static int Solution2(int num1, int num2)
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

        public static int Solution3(int num1, int num2)
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

        public static int Solution4(int age)
        {
            int answer = 0;
            int year = 2022;

            if(age <= 0 || age > 120)
            {
                Console.WriteLine("오류 : age 범위 초과");
            }
            else
            {
                answer = year - age + 1;
                Console.WriteLine("태어난 년도 : {0}",answer);
            }

            return answer;


        }

        public static int Solution5(int num1, int num2)
        {
            int answer = 0;
            if (num1 < 0 || num1 > 10000)
            {
                Console.WriteLine("오류 : num1 범위초과 ");
            }
            else if (num2 < 0 || num2 > 10000)
            {
                Console.WriteLine("오류 : num2 범위초과 ");
            }
            else
            {
                if (num1 == num2)
                    answer = 1;
                else if (num1 != num2)
                    answer = -1;

                Console.WriteLine(answer);
            }

            return answer;

        }

        public static int Solution6(int num1, int num2)
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
                answer = num1 + num2;
                Console.WriteLine(answer);
            }

            return answer;

        }

    }
}
