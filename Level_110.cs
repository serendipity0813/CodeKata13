using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata13
{
    internal class Level_110
    {
        public static long[] Solution101(long[] numbers)
        {
            long[] answer = new long[numbers.Length];
            long count = 0;
            long number = 0;

            for (long i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];
                if (number < 3)
                    count = 1;
                else
                {
                    while (true)
                    {
 
                        if (number % 2 != 0)
                        {
                            number = number / 2;
                            if (count == 0)
                                count = 1;
                            else
                                count *= 2;
                        }
                        else
                        {
                            if (count == 0)
                                count = 1;
                            break;
                        }
                    }
                 
                }
                answer[i] = numbers[i] + count;
                count = 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
            
            return answer;
        }

        public static int Solution102(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;
            return answer;
        }

    }
}