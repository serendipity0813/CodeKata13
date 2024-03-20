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
            int[] arr = {0, 1, 1, 2, 2, 3};
            ProgrammersBasic.Solution95(arr, 3);
        }
    }
}
