using DesignPatternsExamples.Command.Interfaaces;
using System;
using System.Threading;

namespace DesignPatternsExamples.Command.Classes
{
    public class InkjetPrinter : IPrinter
    {
        public void Print(string Text)
        {
            Console.WriteLine("Printer: I have an InkJet and I'm printing now\n");
            Thread.Sleep(1000);
            Console.WriteLine(Text);
        }
    }
}
