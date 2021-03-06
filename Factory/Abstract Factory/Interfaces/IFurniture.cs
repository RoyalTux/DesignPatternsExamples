namespace DesignPatternsExamples.Factory.Abstract_Factory.Interfaces
{
    public interface IFurniture
    {
        IArmchair CreateArmchair();

        ITable CreateTable();

        ISofa CreateSofa();
    }
}
