using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes.Modern
{
    public class ModernFurniture : IFurniture
    {
        public IArmchair CreateArmchair()
        {
            return new ModernArmchair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}
