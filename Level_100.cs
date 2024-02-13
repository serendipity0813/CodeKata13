﻿using System;
using System.Collections.Generic;
using System.Linq;
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
     

        public class Solution_93
        {
            public static int _answer;
            public static bool[] _visited;
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
       

    }
}