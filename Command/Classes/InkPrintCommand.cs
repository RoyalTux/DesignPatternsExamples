using DesignPatternsExamples.Command.Interfaaces;
using System;
using System.Threading;

namespace DesignPatternsExamples.Command.Classes
{
    public class InkPrintCommand : IPrintCommand
    {
        private InkjetPrinter inkie = new InkjetPrinter();

        public void ExecutePrint(string Text)
        {
            Thread.Sleep(500);
            Console.WriteLine("Printer: I'm hanging in the queue!");
            Thread.Sleep(3000);
            Console.WriteLine("Printer: now I'm going to print\n");
            Thread.Sleep(500);
            inkie.Print(Text);
        }
    }
}
