using DesignPatternsExamples.Command.Interfaaces;
using System;
using System.Threading;

namespace DesignPatternsExamples.Command.Classes
{
    public class LaserPrinter : IPrinter
    {
        public void Print(string Text)
        {
            Console.WriteLine("Printer: I have a LaserPrinter and I'm printing now\n");
            Thread.Sleep(500);
            Console.WriteLine(Text);
        }
    }
}
