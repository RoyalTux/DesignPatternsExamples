using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;
using System;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class Furniture
    {
        public void TestFurniture()
        {
            IFurniture furniture;

            Console.WriteLine("Default furniture:");
            furniture = new DefaultFurniture();
            PrintFurniture(furniture);

            Console.WriteLine("Victorian furniture:");
            furniture = new VictorianFurniture();
            PrintFurniture(furniture);

            Console.WriteLine("Modern furniture:");
            furniture = new ModernFurniture();
            PrintFurniture(furniture);
        }

        public void PrintFurniture(IFurniture furniture)
        {
            Console.WriteLine(furniture.CreateArmchair().Name.ToString());
            Console.WriteLine(furniture.CreateArmchair().Purpose());
            Console.WriteLine();
            Console.WriteLine(furniture.CreateTable().Name.ToString());
            Console.WriteLine(furniture.CreateTable().Purpose());
            Console.WriteLine();
            Console.WriteLine(furniture.CreateSofa().Name.ToString());
            Console.WriteLine(furniture.CreateSofa().Purpose());
            Console.WriteLine();
        }
    }
}
