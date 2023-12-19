using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ExceptionServices;

namespace CodeKata13
{
    public class Level_20
    {
        public static string Solution11(int num)
        {
            string answer = "";

            if (num == 0)
                answer = "Even";
            else if (num % 2 == 1 || num % 2 == -1)
                answer = "Odd";
            else if (num % 2 == 0)
                answer = "Even";
            else
                Console.WriteLine("입력값이 잘못되었습니다. int 범위의 정수를 입력해주세요!");

            Console.WriteLine($"1번 문제 : 입력된 정수값 : {num}, 구분 : {answer}");
            return answer;

        }

        public static double Solution12(int[] arr)
        {
            int sum = 0;
            double average = 0;

            if (arr.Length <= 0)
            {
                Console.WriteLine("배열의 크기를 0 이상으로 설정해주세요.");
                return 0;
            }

            else if (arr.Length > 100)
            {
                Console.WriteLine("배열의 크기를 100 이하로 설정해주세요.");
                return 0;
            }

            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                if (arr.Length != 0)
                    average = (double)sum / arr.Length;


                Console.Write("입력배열 : [ ");
                for (int i = 0; i < arr.Length; i++)
                {

                    Console.Write($" {arr[i]} ");
                }
                Console.Write($" ]");
                Console.WriteLine();
                Console.WriteLine($"평균 : {average}");

                return average;
            }


        }

        //다시 풀어야 함
        public static int Solution13(int num)
        {
            int answer = 0;
            int[] arr = new int[6];

            if (num >= 100000)
            {
                arr[0] = num / 100000;
                num -= arr[0] * 100000;
            }
            else
                arr[0] = 0;

            if (num >= 10000)
            {
                arr[1] = num / 10000;
                num -= arr[1] * 10000;
            }
            else
                arr[1] = 0;

            if (num >= 1000)
            {
                arr[2] = num / 1000;
                num -= arr[2] * 1000;
            }
            else
                arr[2] = 0;

            if (num >= 100)
            {
                arr[3] = num / 100;
                num -= arr[3] * 100;
            }
            else
                arr[3] = 0;

            if (num >= 10)
            {
                arr[4] = num / 10;
                num -= arr[4] * 10;
            }
            else
                arr[4] = 0;

            arr[5] = num;

            for(int i=0; i<arr.Length; i++)
            {
                answer += arr[i];
            }

            Console.WriteLine(answer);

            return answer;
        }

        public static int Solution14(int n)
        {
            int answer = 0;

            for(int i=1; i<=n; i++)
            {
                if(n%i == 0)
                {
                    answer += i;
                }
            }

            Console.WriteLine(answer);

            return answer;
        }

        public static int Solution15(int n)
        {
            int answer = 0;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }
            }

            Console.WriteLine(answer);

            return answer;
        }

        //다시 풀어야 함
        public static long[] Solution16(int x, int n)
        {
            long[] answer = new long[n];

            for(int i=1; i <= n; i++)
            {
                answer[i - 1] = x * i;
            }

            for(int j=0; j<n; j++)
            {
                Console.Write(answer[j]);
            }


            return answer;
        }

        //다시 풀어야 함
        public static int[] Solution17(long n)
        {
            int[] answer = new int[12];
            int count = 0;

            while(n>0)
            {
                answer[count] = (int)n % 10;
                n = n / 10;
                count++;
            }


            for (int i=0; i<count; i++)
            {
                Console.Write(answer[i]);
            }


            return answer;
        }

        //다시 풀어야 함
        public static int Solution18(string s)
        {
            int answer = 0;

            answer = Convert.ToInt32(s);


            Console.WriteLine(answer);

            return answer;

        }

        //다시 풀어야 함
        public static int Solution19(int n)
        {
            int answer = 0;
            int root = 1;

            while(true)
            {
                if (n / root == root && n % root == 0)
                {
                    answer = (root + 1) * (root + 1);
                    break;
                }
                else if(root*root>n) 
                {
                    answer = -1;
                    break;
                }
                else
                {
                    root++;
                }

            }

            Console.WriteLine(answer);

            return answer;
        }

        //다시 풀어야 함
        public static long Solution20(long n)
        {
            long answer = 0;
            int count = 0;
            int temp = 0;
            int[] nums = new int[10];
            while(n> 0)
            {
                    nums[count] = (int)n % 10;
                    n = n / 10;
                    count++;
            }

            for(int i=0; i < count; i++)
            {
                for(int  j=1; j < count; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            for( int i=0; i < count-1; i++)
            {
                answer = answer + nums[i];
                answer = answer * 10;
            }

            Console.WriteLine(answer);

            return answer;
        }
    }
}
