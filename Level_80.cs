﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
