using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class DefaultFurniture : IFurniture
    {
        public IArmchair CreateArmchair()
        {
            return new DefaultArmchair();
        }

        public ISofa CreateSofa()
        {
            return new DefaultSofa();
        }

        public ITable CreateTable()
        {
            return new DefaultTable();
        }
    }
}
