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
        static void Main(string[] args)
        {
            int[,] queries = { { 2, 3 }, { 0, 7 }, { 5, 9 }, { 6, 10 } };
            ProgrammersBasic.Solution("rermgorpsam", queries);
        }
    }
}
