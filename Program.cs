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
            string[] keyInput = { "left", "right", "up", "right", "right" };
            int[] board = { 11, 11 };
            ProgrammersNormal.Solution81(2, 2);   
        }

    }

}
