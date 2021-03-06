using DesignPatternsExamples.Adapter.Classes;
using DesignPatternsExamples.ChainOfResponsibility.Classes;
using DesignPatternsExamples.Command.Classes;
using DesignPatternsExamples.Facade.Classes;
using DesignPatternsExamples.Factory.Abstract_Factory.Classes;
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

            Console.WriteLine("**********");

            Secretary testCommand = new Secretary();
            testCommand.PrintDocument();

            Console.WriteLine("**********");

            FacadeExample testFacade = new FacadeExample();
            testFacade.TestFacade();

            Console.WriteLine("**********");

            Furniture testAbstractFactory = new Furniture();
            testAbstractFactory.TestFurniture();

            Console.WriteLine("**********");
        }
    }
}
