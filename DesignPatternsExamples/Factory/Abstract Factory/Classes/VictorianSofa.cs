using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes
{
    public class VictorianSofa : ISofa
    {
        public string Name => "Victorian sofa";

        public string Purpose()
        {
            return "To lay";
        }
    }
}
