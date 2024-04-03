using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection.Emit;
using System.Text;


namespace CodeKata13
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int[,] score = { { 80, 70 }, { 70, 80 }, { 30, 50 }, { 90, 100 }, { 100, 90 }, { 100, 100 }, { 10, 30 } };
            ProgrammersNormal.Solution85(score);   
        }

    }

}
