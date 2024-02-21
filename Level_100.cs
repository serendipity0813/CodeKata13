using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata13
{
    internal class Level_100
    {


        public static List<int> Solution91(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            int[] days = new int[progresses.Length];
            int maxnum = 0;
            int count = 0;

            for(int i = 0; i< progresses.Length; i++)
            {
                days[i] = (100 - progresses[i]) / speeds[i];
                if ((100 - progresses[i]) % speeds[i] != 0)
                    days[i]++;
    
            }

            for(int i=0; i<days.Length; i++)
            {
                if (days[i] > maxnum)
                {
                    if (i != 0)
                        answer.Add(count);

                    maxnum = days[i];
                    count = 1;

                    if (i == days.Length - 1)
                        answer.Add(count);
                }
                else
                {
                    count++;
                    if(i == days.Length - 1)
                        answer.Add(count);
                }
                   
            }
            foreach(int i in answer)
            {
                Console.WriteLine(i);
            }


            return answer;
        }

        public static int Solution92(int[] priorities, int location)
        {
            int answer = 0;
            int count = 0;
            int pivot = priorities.Max();
            int flag = priorities.Length - 1;
            int num = 0;

            while(pivot != 0)
            {
                if (num > priorities.Length - 1)
                    num = 0;

                if (num == flag)
                    pivot--;

                if (priorities[num] == pivot)
                {
                    priorities[num] = 0;
                    flag = num;
                    count++;
                    if(num == location)
                    {
                        answer = count;
                        break;
                    }

                }
                num++;


            }

            Console.WriteLine(answer);
            return answer;
        }
     

        public class Solution_93    //DFS문제 - 나중에 다시 풀어보기
        {
            public static int _answer;
            public static int _length;

            public static int Solution93(int k, int[,] dungeons)
            {
                _length = dungeons.GetLength(0);
                bool[] _visited = new bool[_length];
                DFS(k, _visited, dungeons, 0);
                Console.WriteLine(_answer);
                return _answer;


            }
            public static void DFS(int k, bool[] visited, int[,] dungeons, int count)
            {
                for (int i = 0; i < dungeons.GetLength(0); i++)
                {
                    if (visited[i] == false && k >= dungeons[i, 0])
                    {
                        visited[i] = true;
                        DFS(k - dungeons[i,1], visited, dungeons, count+1);
                        visited[i] = false;
                    }
                }

                if (count > _answer)
                    _answer = count;

            }
        }
       
        public class Solution_94    //DFS문제 -  풀어보기
        {
            public static int _length;
            public static int _answer;

            public static int Solution94(int[] numbers, int target)
            {                
                _answer = 0;
                _length = numbers.Length;

                DFS(0, 0);

                    void DFS(int sum, int index)
                    {
                        if (index == _length)
                        {
                            if (sum == target)
                            {
                                _answer += 1;
                            }

                            DFS(sum + numbers[index], index + 1);
                            DFS(sum - numbers[index], index + 1);
                        }
                 
                    }

                Console.Write(_answer);
                return _answer;

            }
                    
            

        }

        public static int Solution95(int n, int k)  //카카오 입사 - 풀어보기
        {
            int answer = -1;
            return answer;
        }

        public static int[] Solution96(int[] fees, string[] records) //카카오 입사 - 풀어보기
        {
            int[] answer = new int[] { };
            return answer;
        }

        public static int Solution97(string word)
        {
            int answer = 0;
            int num = 3906;

            for(int i=0; i< word.Length; i++)
            {
                num = num / 5;

                switch(word[i])
                {
                    case 'A' :
                        answer += 1;
                            break;
                    case 'E':
                        answer += num + 1;
                        break;
                    case 'I':
                        answer += num * 2 + 1;
                        break;
                    case 'O':
                        answer += num * 3 + 1;
                        break;
                    case 'U':
                        answer += num * 4 + 1;
                        break;

                }
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static int[] Solution98(int[] numbers)
        {
            int[] answer = new int[numbers.Length];

            answer[answer.Length - 1] = -1;

            for (int i= numbers.Length - 2; i >= 0; i--)
            { 

                if (i != 0 && (numbers[i] == numbers[i + 1]))
                {
                    answer[i] = answer[i+1];
                }
                else
                {

                    for (int j = i + 1; j < numbers.Length; j++)
                    {

                        if (numbers[j] > numbers[i])
                        {
                            answer[i] = numbers[j];
                            break;
                        }
                        else if (numbers[j] <= numbers[i])   
                        {
                            if (answer[j] == -1)
                            {
                                answer[i] = -1;
                                break;
                            }
                            else if (answer[j] > numbers[i])
                            {
                                answer[i] = answer[j];
                                break;
                            }
                        }

                    }
                    if (answer[i] == 0)
                        answer[i] = -1;
                }

            }

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.Write(answer[j]);
            }
            return answer;
        }



    }
}
