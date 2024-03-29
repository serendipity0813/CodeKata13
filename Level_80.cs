﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CodeKata13
{
    internal class Level_80
    {
        public static List<int> Solution71(string today, string[] terms, string[] privacies)
        {
            List<int> answer = new List<int>();
            char key = 'A';
            string tyear = today.Substring(0, 4);
            string tmonth = today.Substring(5, 2);
            string tday = today.Substring(8, 2);
            string year;
            string month;
            string day;
            int yearnum;
            int monthnum;
            int daynum;
            var customers = new Dictionary <string, string>();

            for(int i=0; i<privacies.Length; i++)
            {
                year = privacies[i].Substring(0, 4);
                yearnum = Int32.Parse(year);
                month = privacies[i].Substring(5, 2);
                monthnum = Int32.Parse(month);
                day = privacies[i].Substring(8, 2);
                daynum = Int32.Parse(day);
                key = privacies[i][11];
                Console.WriteLine(year + " " + month + " " + day +" " + key);

                for (int j = 0; j < terms.Length; j++)
                {
                    if (key == terms[j][0])
                    {
                        string keymonth = terms[j].Substring(2);
                        monthnum += Int32.Parse(keymonth);
                        break;
                    }

                }

                if (monthnum > 12)
                {
                    if(monthnum % 12 == 0)
                    {
                        yearnum += monthnum / 12 - 1;
                        monthnum = 12;
                    }
                    else
                    {
                        yearnum += monthnum / 12;
                        monthnum = monthnum % 12;
                    }


                }

                if(yearnum < Int32.Parse(tyear))
                {
                    answer.Add(i+1);
                }
                else if(yearnum == Int32.Parse(tyear) && monthnum < Int32.Parse(tmonth))
                {
                    answer.Add(i + 1);
                }
                else if(yearnum == Int32.Parse(tyear) && monthnum == Int32.Parse(tmonth) && daynum <= Int32.Parse(tday))
                {
                    answer.Add(i + 1);
                }

                Console.WriteLine(yearnum + " " + monthnum + " " + daynum + " " );
                Console.WriteLine(tyear + " " + tmonth + " " + tday + " ");
                Console.WriteLine();
            }

            foreach(int elem in answer)
            {
                Console.WriteLine(elem);
            }

            return answer;
        }

        public static string[] Solution72(string[] players, string[] callings)
        {
            string[] answer = new string[players.Length];

            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++)
            {
                dictionary.Add(players[i], i + 1);
                answer[i] = players[i];
            }

            for (int i = 0; i < callings.Length; i++)
            {
                int value = dictionary[callings[i]];
                string key = answer[value-2];
                //var key = dictionary.FirstOrDefault(x => x.Value == value - 1).Key;
                dictionary[key] = value;
                dictionary[callings[i]] = dictionary[callings[i]] - 1;
                answer[value-1] = key;
                answer[value - 2] = callings[i];

            }


            return answer;
        }

        public static int[] Solution73(string[] park, string[] routes)
        {
            int[] answer = new int[2];
            int high = park.Length;
            int width = park[0].Length;
            string number = "";
            int num2 = 0;

            for (int i = 0; i < high; i++)
            {
                for(int j= 0; j < width; j++)
                {
                    if (park[i][j] == 'S')
                    {
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
            }

            for (int i = 0; i < routes.Length; i++)
            {
                bool flag = false;
                switch (routes[i][0])
                {
                    case 'E':
                        number = routes[i].Substring(2);
                        num2 = Int32.Parse(number);
                        if (answer[1] + num2 < width)
                        {
                            for (int j = answer[1]; j <= answer[1] + num2; j++)
                            {
                                int num = answer[0];
                                if (park[num][j] == 'X')
                                {
                                    flag = true;
                                    break;
                                }

                            }
                            if(flag == false)
                            answer[1] += num2;
                        }
                        break;
                    case 'W':
                        number = routes[i].Substring(2);
                        num2 = Int32.Parse(number);
                        if (answer[1] - num2 >= 0 )
                        {
                            for (int j = answer[1]; j >= answer[1] - num2; j--)
                            {
                                int num = answer[0];
                                if (park[num][j] == 'X')
                                {
                                    flag = true;
                                    break;
                                }

                            }
                            if(flag == false)
                            answer[1] -= num2;
                        }
                        break;
                    case 'N':
                        number = routes[i].Substring(2);
                        num2 = Int32.Parse(number);
                        if (answer[0] - num2 >= 0 )
                        {
                            for (int j = answer[0]; j >= answer[0] - num2; j--)
                            {
                                int num = answer[1];
                                if (park[j][num] == 'X')
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == false)
                                answer[0] -= num2;
                        }
                        break;
                    case 'S':
                        number = routes[i].Substring(2);
                        num2 = Int32.Parse(number);                 
                        if (answer[0] + num2 < high)
                        {
                            for (int j = answer[0]; j <= answer[0] + num2; j++)
                            {
                                int num = answer[1];
                                if (park[j][num] == 'X')
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (flag == false)
                                answer[0] += num2;
                        }
                        break;
                }
            }

            return answer;

        }

        public static int[] Solution74(string[] id_list, string[] report, int k)  //나중에 다시 풀어보기
        {
            int[] answer = new int[id_list.Length];
            string[] words; 

            //<id, 배열번호>
            Dictionary<string, int> id_number = new Dictionary<string, int>();

            Dictionary<string, List<string>> reportList = new Dictionary<string, List<string>>();

            for (int i = 0; i < id_list.Length; i++)
            {
                id_number.Add(id_list[i], i);
            }

            for(int i=0; i<report.Length; i++)
            {             
                words = report[i].Split(' ');
                if (reportList.ContainsKey(words[1]) == false)
                    reportList.Add(words[1], new List<string>());
                if (reportList[words[1]].Contains(words[0]) == false)
                    reportList[words[1]].Add(words[0]);
                Console.WriteLine();
            }

            foreach (var list in reportList.Values)
            {
                if (list.Count >= k)
                {
                    foreach (var name in list)
                    {
                        answer[id_number[name]]++;
                    }
                }
            }

            for (int i = 0; i < id_list.Length; i++)
            {
                Console.Write(answer[i]);
            }


            return answer;
        }

        public static string Solution75(string s)
        {
            string answer = "";
            int MinNumber;
            int MaxNumber;
            string[] Numbers;

            Numbers = s.Split(' ');
            MinNumber = int.Parse(Numbers[0]);  
            MaxNumber = int.Parse(Numbers[0]);

            for(int i=1; i<Numbers.Length; i++)
            {
                if (int.Parse(Numbers[i]) < MinNumber)
                    MinNumber = int.Parse(Numbers[i]);
                if (int.Parse(Numbers[i]) > MaxNumber)
                    MaxNumber = int.Parse(Numbers[i]);
            }

            answer = MinNumber.ToString() + ' ' + MaxNumber.ToString();

            Console.WriteLine(answer);
            return answer;
        }

        public static string Solution76(string s)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();
            s = s.ToLower();
            sb.Append(s);
            sb[0] = char.ToUpper(sb[0]);

            for (int i=1; i<sb.Length; i++)
            {
                if (sb[i] != ' ' && sb[i - 1] == ' ')
                    sb[i] = char.ToUpper(sb[i]);
            }

            answer = sb.ToString();
            Console.WriteLine(answer);
            return answer;
        }

        public static int[] Solution77(string s)
        {
            int[] answer = new int[2];
            int count1 = 0;
            bool flag = true;

            while(flag)
            {
                answer[0]++;
                for (int i = 0; i < s.Length; i++)
                {                 
                    if (s[i] == '1')
                        count1++;
                }

                answer[1] += s.Length - count1;
                s = Convert.ToString(count1,2);
                count1 = 0;

                if(s.Length == 1)
                    flag = false;

            }

            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);
            return answer;

        }
        
        public static int Solution78(int n)
        {
            int answer = 0;
            int second = 1;
            int first = 1;
            int temp = 0;

            for(int i=3; i<=n; i++)
            {
                temp = first;
                first += second;
                second = temp;
                first = first & 1234567;
            }

            answer = first;
            Console.WriteLine(answer);
            return answer;
        }

        public static int[] Solution79(int brown, int yellow)
        {
            int[] answer = new int[2];
            int height = 3;
            int length = brown /2 - (height-2);

            while (true)
            {
                if ((length-2) * (height-2) == yellow)
                    break;
                else
                {
                    height++;
                    length = brown / 2 - (height - 2);
                }
            }

            answer[0] = length;
            answer[1] = height;

            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);
            return answer;
        }

        public static int Solution80(int n, int a, int b)
        {
            int answer = 0;
            int pivot = n;
            int count = 0;

            while(n != 1)
            {
                n = n / 2;
                count++;
            }

            while (true)
            {
                pivot = pivot / 2;
                if (a > pivot && b > pivot)
                {
                    a -= pivot;
                    b -= pivot;
                    count--;
                }
                else if (a <= pivot && b <= pivot)
                {
                    count--;
                }
                else
                    break;
            }

            Console.Write(count);
            answer = count;
            return answer;
        }

    }
}
