using System;
using System.Collections.Generic;
using System.Linq;

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

        public static int[] Solution74(string[] id_list, string[] report, int k)
        {
            int[] answer = new int[id_list.Length];
            int[,] reportlist = new int[report.Length, 2];
            string[] words; 

            //<id, 배열번호>
            var id_number = new Dictionary<string, int>();

            //<신고당한사람, 신고받은 횟수>
            var reportcount = new Dictionary<string, int>();


            for (int i = 0; i < id_list.Length; i++)
            {
                id_number.Add(id_list[i], i);
                reportcount.Add(id_list[i], 0);
            }

            for(int i=0; i<report.Length; i++)
            {             
                words = report[i].Split(' ');
                reportlist[i,0] = id_number[words[0]];
                reportlist[i,1] = id_number[words[1]];
                reportcount[words[1]]++;
                Console.Write(reportlist[i,0] + " " + reportlist[i,1]);
                Console.WriteLine();
            }

            for(int i=0; i< id_list.Length; i++)
            {
                if (reportcount[id_list[i]] >= k)
                {
                    for(int j=0; j<report.Length; j++)
                    {
                        if (reportlist[j, 1] == id_number[id_list[i]])
                        {
                            answer[reportlist[j, 0]]++;
                        }
 
                    }
                }

            }

            for (int i = 0; i < id_list.Length; i++)
            {
                Console.Write(answer[i]);
            }


            return answer;
        }

    }
}
