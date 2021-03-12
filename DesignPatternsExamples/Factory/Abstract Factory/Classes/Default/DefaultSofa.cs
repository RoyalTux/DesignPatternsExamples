using DesignPatternsExamples.Factory.Abstract_Factory.Interfaces;

namespace DesignPatternsExamples.Factory.Abstract_Factory.Classes.Default
{
    public class DefaultSofa : ISofa
    {
        public string Name => "Default sofa";

        public string Purpose(string description)
        {
            return "To lay";
        }
    }
}
