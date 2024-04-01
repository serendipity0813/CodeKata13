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
            int[,] dots = { { 1, 1 }, {2, 1}, { 2, 2 }, { 1, 2 } };
            ProgrammersNormal.Solution83(dots);   
        }

    }

}
