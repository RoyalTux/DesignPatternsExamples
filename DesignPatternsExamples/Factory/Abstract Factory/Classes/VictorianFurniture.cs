using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class VictorianFurniture : IFurniture
    {
        public IArmchair CreateArmchair()
        {
            return new VictorianArmchair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
}
