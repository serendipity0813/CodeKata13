﻿using System;
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
            string[] picture = { ".xx...xx.", "x..x.x..x", "x...x...x", ".x.....x.", "..x...x..", "...x.x...", "....x...." };
            ProgrammersBasic.Solution117(picture,2);
        }
    }
}
