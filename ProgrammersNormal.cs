using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace CodeKata13
{
    internal class ProgrammersNormal
    {
        public static int Solution78(int balls, int share)
        {
            int answer = 0;
            return answer;
        }

        public static int Solution80(string[] spell, string[] dic)
        {
            int answer = 2;
            string str1 = "";
            string str2 = "";

            for(int i=0; i<dic.Length; i++)
            {
                char[] words = dic[i].ToCharArray();
                Array.Sort(words);
                Array.Sort(spell);

                if (words.Length == spell.Length)
                {
                   for(int j=0; j<words.Length; j++)
                    {
                        str1 += words[j];
                        str2 += spell[j];
                    }

                    if (str1 == str2)
                    {
                        answer = 1;
                        break;
                    }
                    else
                    {
                        str1 = "";
                        str2 = "";
                    }
                }

            }

            Console.WriteLine(answer);

            return answer;

        }

        public static int Solution81(int M, int N)
        {
            int answer = 0;
            int min = 0;
            int dif = 0;

            if (M < N)
            {
                min = M;
                dif = N - M;
            }
              
            else if(N < M)
            {
                min = N;
                dif = M - N;
            }
         
            else
            {
                min = N;
                dif = 0;
            }

            answer = (min * min - 1) + dif * min; 

            
            return answer;
        }

        public static int[] Solution82(string[] keyinput, int[] board)
        {
            int[] answer = new int[] {0, 0};
            int xnum = (board[0] - 1 )/ 2;
            int ynum = (board[1] - 1) / 2;

            for(int i=0; i<keyinput.Length; i++)
            {
                if (keyinput[i] == "up" && answer[1] + 1 <= ynum)
                    answer[1]++;
                else if (keyinput[i] == "down" && answer[1] - 1 >= -ynum)
                    answer[1]--;
                else if (keyinput[i] == "left" && answer[0] - 1 >= -xnum)
                    answer[0]--;
                else if (keyinput[i] == "right" && answer[0] + 1 <= xnum)
                    answer[0]++;
            }
                

            return answer;
        }

        public static int Solution83(int[,] dots)
        {
            int answer = 0;
            int xnum = 0;
            int ynum = 0;

            if (dots[0, 0] != dots[1, 0])
            {
                xnum = dots[1, 0] - dots[0,0];
                if (xnum < 0)
                    xnum = -xnum;
            }
            else
            {
                xnum = dots[2, 0] - dots[0, 0];
                if (xnum < 0)
                    xnum = -xnum;
            }


            if (dots[0, 1] != dots[1, 1])
            {
                ynum = dots[1, 1] - dots[0, 1];
                if (ynum < 0)
                    ynum = -ynum;
            }
            else
            {
                ynum = dots[2, 1] - dots[0, 1];
                if (ynum < 0)
                    ynum = -ynum;
            }

            answer = xnum * ynum;
            Console.WriteLine(answer);
            return answer;
        }

        public static string Solution84(string[] id_pw, string[,] db)
        {
            string answer = "fail";

            for (int i = 0; i < db.GetLength(0); i++)
            {
                if (id_pw[0] == db[i,0])
                {
                    if (id_pw[1] == db[i, 1])
                    {
                        answer = "login";
                        break;
                    }

                    else
                        answer = "wrong pw";
                }
            }

            return answer;
        }

        public static int[] Solution85(int[,] score)
        {
            int length = score.GetLength(0);
            int[] answer = new int[length];
            float[,] rank = new float[length, 2];
            float[] value = new float[length];
            
            for(int i=0; i < length; i++)
            {
                value[i] = (score[i,0] + score[i,1]) / 2 + (score[i, 0] + score[i, 1]) % 2;
                rank[i,0] = i;
                rank[i, 1] = value[i];
            }

            Array.Sort(value);
            Array.Reverse(value);

            for (int i = 0; i < length; i++)
            {

                for(int j=0; j < length; j++)
                {
                    if (value[i] == rank[j, 1] && answer[(int)rank[j, 0]] == 0)
                        answer[(int)rank[j,0]] = i+1;
                }

            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(answer[i]);
            }

            return answer;
        }

        public static int Solution86(int n)
        {
            int before = 0;
            int answer = n;
            int count = 0;
            int dif = 100;
            
            while(dif != 0)
            {
                for (int i = before + 1; i <= answer; i++)
                {
                    if (i % 3 == 0)
                        count++;
                    else if (i / 10 == 13)
                        count++;
                    else if (i / 10 == 3)
                        count++;
                    else if (i % 10 == 3)
                        count++;
                }

                before = answer;
                answer += count;
                count = 0;
                dif = answer - before;
            }

            Console.WriteLine(answer);
            return answer;

        }

        public static int Solution87(int a, int b)
        {
            int answer = 0;
            int max = 0;
            int div = 0;

            if (a > b)
                max = a;
            else
                max = b;

            for(int i=1; i<=max; i++)
            {
                if (a % i == 0 && b % i == 0)
                    div = i;
            }

         
            b = b / div;

            while(b > 0)
            {
                if (b == 1)
                {
                    b = 0;
                    answer = 1;
                }
                else if (b % 10 == 0)
                {
                    b = b / 10;
                }
                else if (b % 2 == 0)
                {
                    b = b / 2;
                }
                else if (b % 5 == 0)
                {
                    b = b / 5;
                }
                else
                {
                    b = 0;
                    answer =2;
                }
             
            }
         

            Console.WriteLine(answer);
            return answer;
        }

        public static int Solution88(int chicken)
        {
            int answer = 0;           
            int coupon = 0;
            int bonus = 0;

            bool isChange = true;

            while(isChange)
            {
                coupon += chicken;
                chicken = 0;
                if (coupon >= 10)
                {
                    bonus = coupon / 10;
                    coupon -= bonus * 10;
                    chicken += bonus;
                    answer += bonus;
                }
                else
                    isChange = false;

            }

            Console.WriteLine(answer);
            return answer;
        }

        public static int Solution89(string A, string B)
        {
            int answer = -1;
            string str = "";
            char[] words = A.ToCharArray();

            for(int i=0; i<words.Length; i++)
            {
                str = "";
                for(int j=0; j<words.Length; j++)
                {
                    if (i+j <= words.Length - 1)                
                        str += words[i + j];
                    else
                        str += words[i+j - words.Length];
                }
                Console.WriteLine(str);

                if (str == B)
                {
                    if (i == 0)
                        answer = 0;
                    else
                    {
                        answer = words.Length - i;
                    }                     
            
                }                 
                  
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static int[] Solution90(int[] numlist, int n)
        {
            int length = numlist.Length;
            int[] answer = new int[length];
            int dif = 0;
            int closest = 0;

            for(int i=0; i< length; i++)
            {
                dif = 10000;
                closest = 0;

                for (int j=0; j<length; j++)
                {
                    if(n >= numlist[j])
                    {
                        if (n - numlist[j] < dif && numlist[j] != 0)
                        {
                            dif = n - numlist[j];
                            closest = j;
                        }
                        else if (n - numlist[j] == dif && numlist[j] > numlist[closest] && numlist[j] != 0)
                        {
                            dif = n - numlist[j];
                            closest = j;
                        }
                    }
                    else
                    {
                        if (numlist[j] - n < dif && numlist[j] != 0)
                        {
                            dif = numlist[j] - n;
                            closest = j;
                        }
                        else if (numlist[j] - n == dif && numlist[j] > closest && numlist[j] != 0)
                        {
                            dif = numlist[j] - n;
                            closest = j;
                        }
                    }
 


                }

                answer[i] = numlist[closest];
                numlist[closest] = 0;
            }

            for(int i=0; i<length; i++)
            {
                Console.WriteLine(answer[i]);
            }
            return answer;
        }

        public static string Solution91(string polynomial)
        {
            string answer = "";
            int variable = 0;
            int constant = 0;

            string[] polynomials = polynomial.Split(new char[] { ' ' });
            for(int i=0; i<polynomials.Length; i++)
            {
                if (Int32.TryParse(polynomials[i], out int x))
                {
                    constant += Int32.Parse(polynomials[i]);
                }
                else if (polynomials[i] != "+")
                {
                    polynomials[i] = polynomials[i].Replace('x', '0');
                    if (Int32.Parse(polynomials[i]) == 0)
                        variable += 1;
                    else
                        variable += Int32.Parse(polynomials[i]) / 10;
                }
            }

            if (variable == 0)
                answer = constant.ToString();
            else if (constant == 0)
            {
                if(variable != 1)
                   answer = variable + "x";
                else
                    answer = "x";
            }
            else
            {
                if(variable == 1)
                    answer = "x + " + constant;
                else
                    answer = variable + "x + " + constant;
            }
            Console.WriteLine (answer);
            return answer;
        }

        public static int Solution92(int[] array)
        {
            int answer = 0;
            int max = 0;
            int[] countArray = new int[1000];

            for(int i=0; i<array.Length; i++)
            {
                countArray[array[i]]++;
            }

            for(int i=0; i<countArray.Length; i++)
            {
                if (countArray[i] > max)
                {
                    answer = i;
                    max = countArray[i];
                }
                else if (countArray[i] == max)
                    answer = -1;
                
            }

            Console.WriteLine(answer);
            return answer;
        }

        public static string[] Solution93(string[] quiz)
        {
            string[] answer = new string[quiz.Length];
            int first = 0;
            int second = 0;
            int result = 0;

            for(int i=0; i<quiz.Length; i++)
            {
                string[] words = quiz[i].Split(' ');
                first = Int32.Parse(words[0]);
                second = Int32.Parse(words[2]);
                if(words[1] == "+")
                    result = first + second;
                else if (words[1] == "-")
                    result = first - second;

                if (result.ToString() == words[4])
                    answer[i] = "O";
                else
                    answer[i] = "X";

            }
           
            
            return answer;
        }

        public static int Solution94(int[] common)
        {
            int answer = 0;
            int sum = common[1] - common[0];
            int mul = 0;
            if (common[0] != 0)
             mul = common[1] / common[0];

            if (common[2] - common[1] == sum)
                answer = common[common.Length - 1] + sum;
            else if (common[2] / common[1] == mul)
                answer = common[common.Length - 1] * mul;
           
            return answer;
        }

        public static int[] Solution95(int num, int total)
        {
            int[] answer = new int[num];
            int first = 0;
            
            if(num % 2 == 0)
            {
                first = (total / num) - num / 2 + 1;
            }
            else
            {
                first = (total / num) - num / 2; 
            }

            for(int i=0; i< num; i++)
            {
                answer[i] = first + i;
            }
            return answer;
        }

        public static int[] Solution96(int numer1, int denom1, int numer2, int denom2)
        {
            int[] answer = new int[2];
            int numer3 = 0;
            int denom3 = 0;

            if (denom1 != denom2)
            {
                denom3 = denom1 * denom2;
                numer3 = numer1 * denom2 + numer2 * denom1;
            }
               
            else
            {
                numer3 = numer1 + numer2;
                denom3 = denom1;
            }
              
            for(int i= numer3; i >= 1; i--)
            {
                if(numer3 % i==0 &&  denom3 % i==0)
                {
                    numer3 = numer3 / i;
                    denom3 = denom3 / i;
                }
            }

            answer[0] = numer3;
            answer[1] = denom3;
           
            return answer;
        }

        public static int Solution97(int[,] board)
        {
            int answer = 0;
            int length = board.GetLength(0);
            int[,] board2 = new int[length+2,length+2];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (board[i,j] == 1)
                    {
                        board2[i+1,j+1]++;
                        board2[i, j]++;
                        board2[i, j+1]++;
                        board2[i, j+2]++;
                        board2[i+1, j]++;
                        board2[i+1, j+2]++;
                        board2[i+2, j]++;
                        board2[i+2, j+1]++;
                        board2[i+2, j+2]++;
                    }
                    
                }
            }

            for (int i = 1; i < length+1; i++)
            {
                for (int j = 1; j < length+1; j++)
                {
                    Console.Write(board2[i, j] + "   ");
                    if (board2[i, j] == 0)
                    {                     
                        answer++;
                    }

                }
                Console.WriteLine();
            }

                    return answer;
        }

        public static int Solution98(int[,] lines)
        {
            int answer = 0;
            int min = lines[0, 0];
            int max = lines[0, 1];
            int count = 0;
            int length = 0;

            for(int i=0; i<3; i++)
            {
                if(lines[i, 0] < min)
                    min = lines[i, 0];

                if (lines[i, 1] > max)
                    max = lines[i, 1];
            }


            for(float i=min - 0.5f; i < max; i++)
            {
                count = 0;

                if (lines[0, 0] <= i && i <= lines[0, 1])
                    count++;

                if (lines[1, 0] <= i && i <= lines[1, 1])
                    count++;

                if (lines[2, 0] <= i && i <= lines[2, 1])
                    count++;

                if (count > 1)
                    length++;
             
            }

            answer += length;
            return answer;
        }

        public static int Solution99(int[,] dots)
        {
            int answer = 0;
            double[] angle = new double[2];

            angle[0] = (dots[0, 1] - dots[1, 1]) / (dots[0, 0] - dots[1, 0]) + (dots[0, 1] - dots[1, 1]) % (dots[0, 0] - dots[1, 0]);
            angle[1] = (dots[2, 1] - dots[3, 1]) / (dots[2, 0] - dots[3, 0]) + (dots[2, 1] - dots[3, 1]) % (dots[2, 0] - dots[3, 0]);
            if (Math.Abs(angle[0]) == Math.Abs(angle[1]))
                answer = 1;

            angle[0] = (dots[0, 1] - dots[2, 1]) / (dots[0, 0] - dots[2, 0]) + (dots[0, 1] - dots[2, 1]) % (dots[0, 0] - dots[2, 0]);
            angle[1] = (dots[1, 1] - dots[3, 1]) / (dots[1, 0] - dots[3, 0]) + (dots[1, 1] - dots[3, 1]) % (dots[1, 0] - dots[3, 0]);
            if (Math.Abs(angle[0]) == Math.Abs(angle[1]))
                answer = 1;

            angle[0] = (dots[0, 1] - dots[3, 1]) / (dots[0, 0] - dots[3, 0]) + (dots[0, 1] - dots[3, 1]) % (dots[0, 0] - dots[3, 0]);
            angle[1] = (dots[1, 1] - dots[2, 1]) / (dots[1, 0] - dots[2, 0]) + (dots[1, 1] - dots[2, 1]) % (dots[1, 0] - dots[2, 0]);
            if (Math.Abs(angle[0]) == Math.Abs(angle[1]))
                answer = 1;

            return answer;
        }

        public static int Solution100(string[] babbling)
        {
            int answer = 0;
            int num = 0;
            for(int i=0; i<babbling.Length; i++)
            {
                babbling[i] = babbling[i].Replace("aya", "1");
                babbling[i] = babbling[i].Replace("ye", "2");
                babbling[i] = babbling[i].Replace("woo", "3");
                babbling[i] = babbling[i].Replace("ma", "4");
                Console.WriteLine(babbling[i]);
                if (Int32.TryParse(babbling[i], out num))
                    answer++;
            }

            return answer;
        }

    }



}