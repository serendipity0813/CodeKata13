using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

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

        public static List<int> Solution32(int l, int r)
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

        public static int Solution37(int a, int b, int c, int d)
        {
            int answer = 0;      
            int[] nums = { a, b, c, d };
            int[] nums2 = { a, b, c, d };
            int[] count = { 0, 0, 0, 0 };

            for(int i=0; i<4; i++)
            {
                if (nums[i] != 0)
                    count[i]++;
                for(int j = i+1; j<4; j++)
                {
                    if (nums[i] == nums[j] && nums[j] != 0)
                    {
                        count[i]++;
                        nums[j] = 0;
                    }
                }
            }

            for(int i=0; i<4; i++)
            {
                if (count[i] == 4)
                {
                    answer = nums[i] * 1111;
                }
                else if (count[i] == 3)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (nums2[j] != nums2[i])
                        {
                            answer = (10 * nums2[i] + nums2[j]);
                            answer *= answer;
                        }
                    }
                }
                else if (count[i] == 2 && i == 0 && count[i+1] != 1 && count[i + 2] != 1)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (nums2[i] != nums2[j])
                        {
                            if (nums2[i] > nums2[j])
                                answer = (nums2[i] + nums2[j]) * (nums2[i] - nums2[j]);
                            else
                                answer = (nums2[j] + nums2[i]) * (nums2[j] - nums2[i]);
                            break;
                        }
                       
                    }

                    break;
                }
                else if(count[i] == 2)
                {
                    answer = 1;
                    for(int j=0; j<4; j++)
                    {
                        if (nums2[i] != nums2[j])
                            answer *= nums2[j];
                    }
                }

            }

            if(answer == 0)
            {
                answer = 10;
                for (int j = 0; j < 4; j++)
                {
                    if (nums2[j] < answer)
                        answer = nums2[j];
                }
            }

            Console.WriteLine(answer);
            return answer;


        }

        public static string Solution40(string my_string, int[,] queries)
        {
            string answer = my_string;
            string str1 = "";
            string str2 = "";
            string str3 = "";
            char[] words = { };

            for (int i=0; i < queries.GetLength(0); i++)
            {
                if (queries[i, 0] != 0)
                    str1 = answer.Substring(0, queries[i, 0]);
                else
                    str1 = "";

                str2 = answer.Substring(queries[i, 0], queries[i, 1] - queries[i,0] + 1);
                words = str2.Reverse().ToArray();
                str2 = "";
                for(int j=0; j<words.Length; j++)
                {
                    str2 += words[j].ToString();
                }

                if (queries[i, 1] + 1 < my_string.Length)
                    str3 = answer.Substring(queries[i, 1] + 1, answer.Length - queries[i, 1] - 1);
                else
                    str3 = "";

                answer = str1 + str2 + str3;
                Console.WriteLine(answer);
            }

            Console.WriteLine(answer);
            return answer;

        }

        public static List<int> Solution60(int[] arr, int[] query)
        {
            List<int> answer = new List<int>();
            int count = 0;
            int head = 0;
            int tail = 0;

            for (int i = 0; i < query.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for(int j = query[i] + head + 1; j<arr.Length - tail; j++ )
                    {
                        Console.Write(arr[j]);
                        arr[j] = -1;
                        count++;
                    }
                    tail += count;
                    count = 0;
                }
                else if (i % 2 != 0)
                {
                    for (int j = 0+head; j < query[i]+head; j++)
                    {
                        Console.Write(arr[j]);
                        arr[j] = -1;
                        count++;
                    }
                    head += count;
                    count = 0;
                }

                Console.WriteLine();
            }

            for(int i=head; i< arr.Length - tail; i++)
            {
                answer.Add(arr[i]);
                Console.Write(arr[i]);
            }

            return answer;
        }

        public static List<int> Solution95(int[] arr, int k)
        {
            List<int> answer = new List<int>();

            for(int i=0; i<arr.Length; i++)
            {
                if (!answer.Contains(arr[i]))
                    answer.Add(arr[i]);

                if (answer.Count == k)
                    break;
            }

            if(answer.Count < k)
            {
                int num = k-answer.Count;
                for(int i=0; i<num; i++)
                {
                    answer.Add(-1);
                }
            }

            foreach (int i in answer)
                Console.WriteLine(i);

            return answer;
        }

        public static int Solution102(int[] rank, bool[] attendance)
        {
            int answer = 0;
            int count = 0;
            int[] top = new int[3];

            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();

            Dictionary<int, bool> sortdict = new Dictionary<int, bool>();

            for (int i=0; i<rank.Length; i++)
            {
                dictionary.Add(rank[i], attendance[i]);
            }

            List <int> arr = dictionary.Keys.ToList();
            arr.Sort();

            for (int i = 0; i < arr.Count; i++)
            {
                sortdict.Add(arr[i], dictionary[arr[i]]);
                if(dictionary[arr[i]] && count < 3)
                {
                    for(int j=0; j<rank.Length; j++)
                    {
                        if (rank[j] == arr[i])
                        {
                            top[count] = j;
                            count++;
                        }
                    }
                }

                if (count >= 3)
                    break;
            }

            answer = top[0] * 10000 + top[1] * 100 + top[2];
            Console.WriteLine(answer);
            return answer;
        }

        public static string[] Solution117(string[] picture, int k)
        {
            string[] answer = new string[] { };
            return answer;
        }


    }

}