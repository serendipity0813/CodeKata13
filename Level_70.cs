using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata13
{
    internal class Level_70
    {
        public static int[] Solution61(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];
            int winpoint = 0;
            int count = 0;

            for(int i = 0; i < lottos.Length; i++)
            {
                if (lottos[i] == 0)
                    count++;
                else
                {
                    for(int j=0; j < win_nums.Length; j++)
                    {
                        if (win_nums[j] == lottos[i])
                            winpoint++;
                    }
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(winpoint);

            answer[0] = 7 - winpoint - count;
            if (answer[0] == 7)
                answer[0] = 6;
            answer[1] = 7 - winpoint;
            if (answer[1] == 7)
                answer[1] = 6;

            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);

            return answer;
        }

        public static int Solution62(string[] babbling)
        {
            int answer = 0;
            int num = 0;
            string[] words = { "aya", "ye", "woo", "ma" };

            for (int i = 0; i < babbling.Length; i++)
            {
                for(int j=0; j < words.Length; j++)
                {
                    babbling[i] = babbling[i].Replace(words[j], $"{j}");
                    babbling[i] = babbling[i].Replace($"{j}{j}", $"{j}" + words[j]);
                }
  

                if(int.TryParse(babbling[i], out num) == true )
                    answer++; 
                Console.WriteLine(babbling[i]);
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static string Solution63(string X, string Y)
        {
            string answer = "";
            StringBuilder subanswer = new StringBuilder();
            int[] countx = new int[10];
            int[] county = new int[10];
            int count = 0;

 
            for (int i = 0; i < X.Length; i++)
            {
                switch(X[i])
                { 
                    case '0':
                        countx[0]++;
                        break;
                    case '1':
                        countx[1]++;
                        break;
                    case '2':
                        countx[2]++;
                        break;
                    case '3':
                        countx[3]++;
                        break;
                    case '4':
                        countx[4]++;
                        break;
                    case '5':
                        countx[5]++;
                        break;
                    case '6':
                        countx[6]++;
                        break;
                    case '7':
                        countx[7]++;
                        break;
                    case '8':
                        countx[8]++;
                        break;
                    case '9':
                        countx[9]++;
                        break;

                }
            }

            for (int i = 0; i < Y.Length; i++)
            {
                switch (Y[i])
                {
                    case '0':
                        county[0]++;
                        break;
                    case '1':
                        county[1]++;
                        break;
                    case '2':
                        county[2]++;
                        break;
                    case '3':
                        county[3]++;
                        break;
                    case '4':
                        county[4]++;
                        break;
                    case '5':
                        county[5]++;
                        break;
                    case '6':
                        county[6]++;
                        break;
                    case '7':
                        county[7]++;
                        break;
                    case '8':
                        county[8]++;
                        break;
                    case '9':
                        county[9]++;
                        break;

                }
            }


            for(int i = 9; i>=0; i--)
            {
                if (countx[i] > county[i])
                {
                    for (int j = 0; j < county[i]; j++)
                    {
                        subanswer.Append(i);
                    }
                       
                }

                else if (countx[i] < county[i])
                {
                    for (int j = 0; j < countx[i]; j++)
                    {
                        subanswer.Append(i);
                    }
                }

                else
                {
                    for (int j = 0; j < countx[i]; j++)
                    {
                        subanswer.Append(i);
                    }
                }

                if (countx[i] != 0 && county[i] != 0)
                    count++;
            }
          
            answer = subanswer.ToString();

           

            if (count== 0)
                answer = "-1";

            if (answer[0] == '0')
                answer = "0";

            Console.WriteLine(answer);
            return answer;

        }

        public static int Solution64(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            int[] students = new int[n];

            for(int i = 0; i < n; i++)
            {
                students[i] = 1;

                for(int j = 0; j<lost.Length; j++)
                {
                    if (i == lost[j] - 1)
                        students[i]--; 
                }

                for (int k = 0; k < reserve.Length; k++)
                {
                    if (i == reserve[k] - 1)
                        students[i]++;
                }            

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(students[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (students[i] == 0)
                {
                    if (i == 0)
                    {
                        if (students[i + 1] == 2)
                        {
                            students[i]++;
                            students[i + 1]--;
                        }
                    }
                    else if (i == n - 1)
                    {
                        if (students[i - 1] == 2)
                        {
                            students[i]++;
                            students[i - 1]--;
                        }
                    }
                    else
                    {
                        if (students[i - 1] == 2)
                        {
                            students[i]++;
                            students[i - 1]--;
                        }
                        else if (students[i + 1] == 2)
                        {
                            students[i]++;
                            students[i + 1]--;
                        }
                    }

                }

            }

            for (int i = 0; i < n; i++)
            {
                if (students[i] > 0)
                    answer++;
            }

            Console.WriteLine(answer);
            return answer;

        }

        
        public static int Solution65(string s)
        {
            int answer = 0;
            char start = ' ';
            int same = 0;
            int differ = 0;
            bool flag = true;

            for(int i=0; i<s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    answer++;
                    break;
                }


                if (flag)
                {
                    start = s[i];
                    same = 1;
                    differ = 0;
                    flag = false;

                }

                else
                {
                    if (s[i] == start)
                        same++;
                    else
                        differ++;

                    if(same == differ)
                    {
                        flag = true;
                        answer++;
                    }

                }
            }


            Console.WriteLine(answer);
            return answer;
        }

        public static int[] Solution66(string[] keymap, string[] targets)
        {
            int[] answer = new int[targets.Length];
            int count = 0;


            for(int i=0; i<targets.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(i + "회차 ");
                for (int j = 0; j < targets[i].Length; j++)
                {
                    count = 200;
                    Console.WriteLine();
                    Console.Write(j + "번째 ");

                        for (int k = 0; k < keymap.Length; k++)
                        {
                            for(int num = 0; num < keymap[k].Length; num++)
                            {
                                if (keymap[k][num] == targets[i][j])
                                {
                                    if(num < count-1)
                                    count = num+1;
                                    break;
                                }
                            }
                            
                        }

                    if (count != 200)
                        answer[i] += count;

                    else if (count == 200)
                    {
                        answer[i] = -1;
                        break;
                    }
                       

                    Console.Write(answer[i]);
                }


            }
            Console.WriteLine();

            for (int i=0; i<targets.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }

            return answer;
        }

        public static string Solution67(string s, string skip, int index)
        {
            string answer = "";
            List<int> skips = new List<int>();

            foreach (char c in skip)
                skips.Add(c);

            for (int i = 0; i < s.Length; i++)
            {

                int alp = Convert.ToInt32(s[i]);

                for(int j=0; j<index; j++)
                {
                    alp++;

                    if (alp > 122)
                        alp -= 26;

                    if (skips.Contains(alp))
                        j--;
                    
                }

                answer += Convert.ToChar(alp); 

                Console.WriteLine(answer);
            }

            return answer;

        }



    }
}
