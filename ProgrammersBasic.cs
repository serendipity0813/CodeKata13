using System;

namespace CodeKata13
{
    internal class ProgrammersBasic
    {

        public static void Solution1()
        {
            string answer = "";
            answer = Console.ReadLine();
            Console.WriteLine(answer);
        }

        public static void Solution2()
        {
            string[] input;
            input = Console.ReadLine().Split(' ');
            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

        }

        public static void Solution3()
        {
            string[] input;
            input = Console.ReadLine().Split(' ');
            string str = input[0];
            int num = Int32.Parse(input[1]);
            for(int i = 0; i < num; i++)
            {
                Console.Write(str);
            }

        }

        public static void Solution4()
        {
            string input;
            string answer = "";
            input = Console.ReadLine();
            for(int i=0; i<input.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                {
                    answer += input[i].ToString().ToLower();
                }
                else if (Char.IsLower(input[i]))
                {
                    answer += input[i].ToString().ToUpper();
                }

            }
        
            Console.WriteLine(answer);
        }

        public static void Solution5()
        {
            string input = "!@#$%^&*(\\'\"<>?:;\r\n";
            
            Console.WriteLine(input);
        }

        public static void Solution6()
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);

            Console.WriteLine("{0} + {1} = {2}", a,b,a+b);
        }

        public static void Solution7()
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            string a = input[0];
            string b = input[1];

            Console.WriteLine("{0}{1}", a, b);
        }

        public static string Solution10(string my_string, string overwrite_string, int s)
        {
            string answer = "";

            for(int i=0; i<my_string.Length; i++)
            {
                if (i < s)
                    answer += my_string[i];
                else if (i >= s && i - s < overwrite_string.Length)
                {
                    answer += overwrite_string[i - s];
                }
                else
                    answer += my_string[i];
            }

            Console.WriteLine(answer);

            return answer;
        }

        public static int Solution24(int[] num_list)
        {
            int answer = 0;
            int square = 1;
            int sum = 0;

            for (int i = 0; i < num_list.Length; i++)
            {
                square *= num_list[i];
                sum += num_list[i];
            }

            sum = sum * sum;

            if (square < sum)
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }

            Console.WriteLine(answer);
            return answer;
        }

    }

}