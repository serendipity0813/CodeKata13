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
            string[] spell = { "s", "o", "m", "d" };
            string[] dic = {"moos", "dzx", "smm", "sunmmo", "som" };
            ProgrammersNormal.Solution81(spell, dic);   
        }

    }

}
