﻿using DesignPatternsExamples.Adapter.Classes;
using DesignPatternsExamples.ChainOfResponsibility.Classes;
using DesignPatternsExamples.Command.Classes;
using DesignPatternsExamples.Facade.Classes;
using DesignPatternsExamples.Factory.Abstract_Factory.Classes;
using DesignPatternsExamples.Factory.Factory_Method.Classes;
using DesignPatternsExamples.State.Classes;
using System;

namespace DesignPatternsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterExample testAdapter = new AdapterExample();
            testAdapter.TestAdapter();

            Console.WriteLine("\n**********");

            ChainOfResponsibilityExample testChainOfResponsibility = new ChainOfResponsibilityExample();
            testChainOfResponsibility.TestChainOfResponsibility();

            Console.WriteLine("\n**********");

            Secretary testCommand = new Secretary();
            testCommand.PrintDocument();

            Console.WriteLine("\n**********");

            FacadeExample testFacade = new FacadeExample();
            testFacade.TestFacade();

            Console.WriteLine("\n**********");

            Furniture testAbstractFactory = new Furniture();
            testAbstractFactory.TestFurniture();

            Console.WriteLine("\n**********");

            FactoryMethodExample testFactoryMethod = new FactoryMethodExample();
            testFactoryMethod.TestFactoryMethod();

            Console.WriteLine("\n**********");

            OrderState OrderState = new OrderState();
            OrderState.Register();
            OrderState.Approve();
            OrderState.Dispatch();
        }
    }
}
