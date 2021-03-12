using DesignPatternsExamples.Factory.Abstract_Factory.Classes.Default;
using DesignPatternsExamples.Factory.Abstract_Factory.Classes.Modern;
using DesignPatternsExamples.Factory.Abstract_Factory.Classes.Victorian;
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
            Console.WriteLine(furniture.Create().Name);
            Console.WriteLine(((IArmchair)furniture.Create()).Purpose(10));
            Console.WriteLine();
            Console.WriteLine(furniture.Create().Name);
            Console.WriteLine(((ITable)furniture.Create()).Purpose());
            Console.WriteLine();
            Console.WriteLine(furniture.Create().Name);
            Console.WriteLine(((ISofa)furniture.Create()).Purpose("additional description"));
            Console.WriteLine();
        }
    }
}
