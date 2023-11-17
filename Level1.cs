using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    public class Level1
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

        public static float Solution12(int[] arr)
        {
            int sum = 0;
            int average = 0;

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
                    average = sum / arr.Length;


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

        public static int Solution3(int num)
        {




            return 0;
        }
    }
}
