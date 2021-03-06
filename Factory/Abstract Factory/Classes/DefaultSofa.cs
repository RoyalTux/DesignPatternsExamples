using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class DefaultSofa : ISofa
    {
        public string Name => "Default sofa";

        public string Purpose()
        {
            return "To lay";
        }
    }
}
