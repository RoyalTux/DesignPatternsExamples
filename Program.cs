using DesignPatternsExamples.Adapter.Classes;
using DesignPatternsExamples.ChainOfResponsibility.Classes;
using System;

namespace DesignPatternsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterExample testAdapter = new AdapterExample();
            testAdapter.TestAdapter();

            Console.WriteLine("**********");

            ChainOfResponsibilityExample testChainOfResponsibility = new ChainOfResponsibilityExample();
            testChainOfResponsibility.TestChainOfResponsibility();
        }
    }
}
