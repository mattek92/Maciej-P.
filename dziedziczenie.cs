//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Zwierze
    {
        public virtual void DajGlos ()
        {
            Console.Write("grr, ");
        }
    }
    public class Pies : Zwierze
    {
        public override void DajGlos()
        {
            Console.Write("szczekam ");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Pies pies = new Pies();
            Zwierze zw = new Zwierze();
            zw.DajGlos();
            pies.DajGlos();
            zw = pies;
            zw.DajGlos();
            pies.DajGlos();
        }
    }
}
