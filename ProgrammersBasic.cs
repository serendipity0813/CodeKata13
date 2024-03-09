using System;
using System.Collections.Generic;

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

        public static int Solution19(string ineq, string eq, int n, int m)
        {
            int answer = 0;

            if(n==m)
            {
                if (eq == "=")
                {
                    answer = 1;
                }
                else
                    answer = 0;
            }
            else
            {
                if (n < m && ineq == "<")
                    answer = 1;
                else if (n > m && ineq == ">")
                    answer = 1;
                else
                    answer = 0;
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static string Solution21(string code)
        {
            string answer = "";
            string ret = "";
            int mode = -1;

            for(int i=0; i<code.Length; i++)
            {
                if (code[i] == '1')
                    mode = -mode;
                else if(mode < 0)
                {
                    if (i % 2 == 0)
                        ret += code[i].ToString();
                }
                else if(mode > 0)
                {
                    if (i % 2 == 1)
                        ret += code[i].ToString();
                }
            }

            if (ret == "")
                answer = "EMPTY";
            else
                answer = ret;

            Console.WriteLine (answer);
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

        public static int[] Solution30(int[] arr, int[,] queries)
        {
            int length = queries.GetLength(0);
            int[] answer = new int[length];
            int pivot = -1;

            for (int i=0; i<length; i++)
            {
                pivot = -1;
                for(int j = queries[i,0]; j <= queries[i,1]; j++)
                {
                    if (arr[j] > queries[i, 2])
                    {
                        if (pivot == -1)
                            pivot = arr[j];
                        else if (arr[j] < pivot)
                            pivot = arr[j];
                                
                    }
                }
                answer[i] = pivot;
            }

            for(int i=0; i<length; i++)
            {
                Console.WriteLine(answer[i]);
            }

            return answer;
        }

        public static List<int> Solution(int l, int r)
        {
            List<int> answer = new List<int>();
            string targetNumber = "";
            bool flag = true;

            for(int i=l; i<= r; i++)
            {
                flag = true;
                targetNumber = i.ToString();
                for(int j=0; j<targetNumber.Length; j++)
                {
                    if (targetNumber[j] != '5' && targetNumber[j] != '0')
                    {
                        flag = false;
                        break;
                    }
                           
                }

                if(flag)
                {
                    answer.Add(i);
                }
                
            }

            if(answer.Count == 0)
                answer.Add(-1);

            foreach(int i in answer)
            {
                Console.WriteLine(i);
            }

            return answer;
        }

    }

}