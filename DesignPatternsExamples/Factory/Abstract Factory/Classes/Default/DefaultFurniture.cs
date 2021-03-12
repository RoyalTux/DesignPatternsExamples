using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes.Default
{
    public class DefaultFurniture : IFurniture
    {
        public IBaseProduct Create()
        {
            return new DefaultArmchair();
        }
    }
}
