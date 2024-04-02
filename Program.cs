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
            int[,] score = { { 80, 70 }, { 90, 50 }, { 40, 70 }, { 50, 80 } };
            ProgrammersNormal.Solution85(score);   
        }

    }

}
