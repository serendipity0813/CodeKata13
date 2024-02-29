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
            int truckCount = 0;
            int timeCount = 0;
            int queueSum = 0;
            


            Queue<int> queue = new Queue<int>();

            //다리 위 무게 체크
            //마지막 시간 계산


            while(true)
            {

                if (queue.Count == bridge_length)
                {
                    queueSum -= queue.Dequeue();
                }
                                
                if(queueSum + truck_weights[truckCount] <= weight)
                {
                    queue.Enqueue(truck_weights[truckCount]);
                    queueSum += truck_weights[truckCount];
                    truckCount++;
                }
                else
                {
                    queue.Enqueue(0);
                }

                if (truckCount == truck_weights.Length)
                {
                    timeCount += bridge_length+1;
                    break;
                }
                else
                    timeCount++;
                

            }

            answer = timeCount;
            Console.WriteLine(answer);
            return answer;
        }

    }
}